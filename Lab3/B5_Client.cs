using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class B5_Client : Form
    {
        private TcpClient client;
        private NetworkStream clientStream;
        private string userName;

        public B5_Client()
        {
            InitializeComponent();
        }

        private void ConnectToServer()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên của bạn trước khi kết nối.");
                    return;
                }

                userName = txtName.Text;

                client = new TcpClient();
                client.Connect("127.0.0.1", 8888); // Kết nối đến địa chỉ mặc định (localhost)
                clientStream = client.GetStream();
                MessageBox.Show("Connected to server.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendDataToServer(string foodName)
        {
            try
            {
                if (clientStream != null)
                {
                    if (string.IsNullOrWhiteSpace(foodName))
                    {
                        MessageBox.Show("Vui lòng nhập tên món ăn.");
                        return;
                    }

                    string dataToSend = $"add,{foodName},{userName}";
                    byte[] data = Encoding.UTF8.GetBytes(dataToSend);

                    clientStream.Write(data, 0, data.Length);
                    clientStream.Flush();
                }
                else
                {
                    MessageBox.Show("Not connected to the server.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string foodName = txtFood.Text;
            SendDataToServer(foodName);
        }
    }
}
