using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab3
{
    public partial class B1_UDPServer : Form
    {
        private List<string> listmessage = new List<string>();
        private UdpClient udpClient;

        public B1_UDPServer()
        {
            InitializeComponent();
            udpClient = new UdpClient();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thrUDP = new Thread(new ThreadStart(svThread));
            thrUDP.Start();
        }

        private void svThread()
        {
            if (txtPort.Text != "")
            {
                udpClient = new UdpClient(Int32.Parse(txtPort.Text));
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                while (true)
                {
                    IPEndPoint ipendpoint = new IPEndPoint(ip, Int32.Parse(txtPort.Text));
                    btnListen.Invoke((MethodInvoker)delegate {
                        btnListen.Enabled = false;
                    });
                    Byte[] receiveBytes = udpClient.Receive(ref ipendpoint);
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    AppendReceivedMessage(ip.ToString() + ": " + returnData + "\r\n");
                }
            }
        }

        private void AppendReceivedMessage(string message)
        {
            if (txtReceivedMessage.InvokeRequired)
            {
                txtReceivedMessage.Invoke((MethodInvoker)delegate {
                    AppendReceivedMessage(message);
                });
            }
            else
            {
                txtReceivedMessage.Text += message + "\n";
            }
        }
    }
}
