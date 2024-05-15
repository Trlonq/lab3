using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B1_UDPClient : Form
    {
        public B1_UDPClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient udpClient = new UdpClient();
                string ip = txtIP.Text;
                int port = Int32.Parse(txtPort.Text);
                string message = txtMessage.Text;

                Byte[] sendBytes = Encoding.UTF8.GetBytes(message);
                udpClient.Send(sendBytes, sendBytes.Length, ip, port);

                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
