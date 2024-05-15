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
    public partial class B2_Server : Form
    {
        public B2_Server()
        {
            InitializeComponent();
        }

        bool isListening = false;
        IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);


        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);

            Socket clientSocket = listenerSocket.Accept();
            listViewCommand.Items.Add("New client connected");

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                }
                while (text[text.Length - 1] != '\n');

                if (!string.IsNullOrWhiteSpace(text))
                    listViewCommand.Items.Add(text);
            }
            listenerSocket.Close();
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            if (isListening) return;
            isListening = true;
            CheckForIllegalCrossThreadCalls = false;

            Thread serverThread = new Thread(StartUnsafeThread);
            listViewCommand.Items.Add("Telnet is running on" + ipepServer.ToString());

            serverThread.IsBackground = true;
            serverThread.Start();
        }
    }
}

