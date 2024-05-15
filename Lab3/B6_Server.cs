using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab3
{
    public partial class B6_Server : Form
    {
        private byte[] _buffer = new byte[1024];
        public List<ClientSocket> ConnectedClients { get; set; }
        private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public B6_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ConnectedClients = new List<ClientSocket>();
        }

        private void SetupServer()
        {
            serverStatusLabel.Text = "Listening . . .";
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 100));
            serverSocket.Listen(1);

            serverSocket.BeginAccept(AcceptCallback, null);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            Socket clientSocket = serverSocket.EndAccept(ar);
            ConnectedClients.Add(new ClientSocket(clientSocket));
            connectedClientsListBox.Items.Add(clientSocket.RemoteEndPoint.ToString());
            serverStatusLabel.Text = "Client connected . . .";

            clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceiveCallback, clientSocket);
            serverSocket.BeginAccept(AcceptCallback, null);
        }

        static string lastClosedClient = "";

        private void ReceiveCallback(IAsyncResult ar)
        {
            Socket clientSocket = (Socket)ar.AsyncState;

            if (clientSocket.Connected)
            {
                int received;
                try
                {
                    received = clientSocket.EndReceive(ar);
                }
                catch (Exception)
                {
                    RemoveDisconnectedClient(clientSocket);
                    return;
                }
                if (received != 0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(_buffer, dataBuf, received);
                    string text = Encoding.UTF8.GetString(dataBuf);
                    string response = string.Empty;

                    if (text.Contains("@@"))
                    {
                        UpdateClientName(text, clientSocket);
                        SendNames();
                        return;
                    }
                    ProcessMessage(text, clientSocket);
                }
                else
                {
                    RemoveDisconnectedClient(clientSocket);
                }
            }
            clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), clientSocket);
        }

        public void RemoveDisconnectedClient(Socket clientSocket)
        {
            for (int i = 0; i < ConnectedClients.Count; i++)
            {
                if (ConnectedClients[i]._Socket.RemoteEndPoint.ToString().Equals(clientSocket.RemoteEndPoint.ToString()))
                {
                    lastClosedClient = ConnectedClients[i]._Name.Substring(1, ConnectedClients[i]._Name.Length - 1);
                    ConnectedClients.RemoveAt(i);
                    for (int j = 0; j < connectedClientsListBox.Items.Count; j++)
                    {
                        if (connectedClientsListBox.Items[j].Equals(lastClosedClient))
                        {
                            connectedClientsListBox.Items.RemoveAt(j);
                        }
                    }
                }
            }
        }

        public void UpdateClientName(string text, Socket clientSocket)
        {
            for (int i = 0; i < connectedClientsListBox.Items.Count; i++)
            {
                if (clientSocket.RemoteEndPoint.ToString().Equals(ConnectedClients[i]._Socket.RemoteEndPoint.ToString()))
                {
                    connectedClientsListBox.Items.RemoveAt(i);
                    connectedClientsListBox.Items.Insert(i, text.Substring(1, text.Length - 1));
                    ConnectedClients[i]._Name = text;
                    clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), clientSocket);
                    return;
                }
            }
        }

        public void ProcessMessage(string text, Socket clientSocket)
        {
            int index = text.IndexOf(" ");
            string cli = text.Substring(0, index);

            string message = "";
            int length = (text.Length) - (index + 2);
            index = index + 2;
            message = text.Substring(index, length);
            SendReceivedMessage(cli, text, message);
            for (int i = 0; i < ConnectedClients.Count; i++)
            {
                if (clientSocket.RemoteEndPoint.ToString().Equals(ConnectedClients[i]._Socket.RemoteEndPoint.ToString()))
                {
                    messageHistoryRichTextBox.AppendText("\n" + ConnectedClients[i]._Name + ": " + text);
                }
            }
        }

        public void SendReceivedMessage(string cli, string text, string message)
        {
            try
            {
                cli = "@" + cli;

                int index = message.IndexOf("*") + 1;
                string parceled = message.Substring(index, message.Length - index);
                string mess = message.Substring(0, index - 1);
                string toSend = $"{parceled}: {mess}";

                foreach (var clientSocket in ConnectedClients)
                {
                    if (clientSocket._Socket.Connected && clientSocket._Name.Equals(cli))
                    {
                        SendData(clientSocket._Socket, toSend);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi gửi tin: {e.Message}");
            }
        }

        void SendData(Socket socket, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void SendCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            socket.EndSend(ar);
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            SetupServer();
        }

        public void SendNames()
        {
            foreach (var clientSocket in ConnectedClients)
            {
                if (clientSocket._Socket.Connected)
                {
                    foreach (var item in connectedClientsListBox.Items)
                    {
                        SendData(clientSocket._Socket, item.ToString());
                    }
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in connectedClientsListBox.SelectedItems)
            {
                string selectedClient = selectedItem.ToString();
                foreach (var clientSocket in ConnectedClients)
                {
                    if (clientSocket._Socket.Connected && clientSocket._Name.Equals("@" + selectedClient))
                        SendData(clientSocket._Socket, messageTextBox.Text);
                }
            }
            messageHistoryRichTextBox.AppendText("\nServer: " + messageTextBox.Text);
        }

        public class ClientSocket
        {
            public Socket _Socket { get; }
            public string _Name { get; set; }
            public ClientSocket(Socket socket)
            {
                _Socket = socket;
            }
        }
    }
}
