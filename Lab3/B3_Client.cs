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
    public partial class B3_Client : Form
    {
        public B3_Client()
        {
            InitializeComponent();
        }

        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        TcpClient tcpClient = new TcpClient();
        NetworkStream? ns;
        bool isConnected = false;

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnected)
                {
                    if (tcpClient.Client == null || !tcpClient.Connected)
                    {
                        tcpClient = new TcpClient();
                        tcpClient.Connect(ipEndPoint);
                    }

                    ns = tcpClient.GetStream();
                    isConnected = true;
                    MessageBox.Show("Connected to server");
                }
                else
                {
                    MessageBox.Show("Already connected to server");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (isConnected)
                {
                    tcpClient.Close();
                    isConnected = false;
                    MessageBox.Show("Disconnected from server");
                }
                else
                {
                    MessageBox.Show("Already disconnected from server");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnected)
                {
                    MessageBox.Show("Not connected to server");
                    return;
                }

                string message = txt_Message.Text.Trim();
                if (string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Please enter a message to send");
                    return;
                }

                byte[] data = Encoding.ASCII.GetBytes(message + "\n");
                ns.Write(data, 0, data.Length);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void frm_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (isConnected)
                {
                    tcpClient.Close();
                    isConnected = false;
                }

                if (ns != null)
                    ns.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
