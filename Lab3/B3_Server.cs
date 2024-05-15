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

namespace Lab3
{
    public partial class B3_Server : Form
    {
        public B3_Server()
        {
            InitializeComponent();
        }

        bool isListening = false;
        IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

        Thread? listenThread;
        Socket? listenerSocket;
        List<Socket> clientSockets = new List<Socket>();

        private void ListenForClients()
        {
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(10);

            lsv_Messages.Items.Add("Server is running on " + ipepServer.ToString());

            while (isListening)
            {
                try
                {
                    Socket clientSocket = listenerSocket.Accept();
                    clientSockets.Add(clientSocket);
                    lsv_Messages.Items.Add("New client connected");

                    Thread clientThread = new Thread(() => HandleClient(clientSocket));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void HandleClient(Socket clientSocket)
        {
            try
            {
                int bytesReceived;
                byte[] recv = new byte[1024];

                while (true)
                {
                    StringBuilder sb = new StringBuilder();
                    do
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        sb.Append(Encoding.ASCII.GetString(recv, 0, bytesReceived));
                    } while (clientSocket.Available > 0);

                    string receivedText = sb.ToString().Trim();
                    if (!string.IsNullOrEmpty(receivedText))
                    {
                        // Hiển thị tin nhắn từ client trên ListView
                        string formattedMessage = $"From client: {receivedText}";
                        lsv_Messages.Invoke((MethodInvoker)delegate
                        {
                            lsv_Messages.Items.Add(formattedMessage);
                        });

                        // Gửi tin nhắn đến tất cả các client khác
                        byte[] sendBuffer = Encoding.ASCII.GetBytes(receivedText + "\n");
                        foreach (Socket socket in clientSockets)
                        {
                            if (socket != clientSocket && socket.Connected)
                            {
                                socket.Send(sendBuffer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            if (isListening) return;
            isListening = true;
            CheckForIllegalCrossThreadCalls = false;

            listenThread = new Thread(ListenForClients);
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void frm_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            isListening = false;
            foreach (Socket socket in clientSockets)
            {
                if (socket != null && socket.Connected)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
            }
            if (listenerSocket != null && listenerSocket.Connected)
            {
                listenerSocket.Close();
            }
        }
    }
}
