using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B6_Client : Form
    {
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public B6_Client()
        {
            InitializeComponent();
        }

        byte[] _receivedBuffer = new byte[1024];

        private void NhanDuLieu(IAsyncResult ar)
        {
            int khongCoTrongDanhSach = 0;

            try
            {
                Socket socket = (Socket)ar.AsyncState;
                int nhanDuoc = socket.EndReceive(ar);
                byte[] duLieuBuffer = new byte[nhanDuoc];
                Array.Copy(_receivedBuffer, duLieuBuffer, nhanDuoc);
                string chuoiNhanDuoc = Encoding.UTF8.GetString(duLieuBuffer);

                if (chuoiNhanDuoc.Contains("delete*"))
                {
                    string xoa = chuoiNhanDuoc.Substring(7, (chuoiNhanDuoc.Length - 7));
                    Console.WriteLine("Giá trị: " + xoa);
                    for (int j = 0; j < listBox1.Items.Count; j++)
                    {
                        if (listBox1.Items[j].Equals(xoa))
                        {
                            listBox1.Items.RemoveAt(j);
                        }
                    }
                }
                else if (chuoiNhanDuoc.Contains("@"))
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.Items[i].ToString().Equals(chuoiNhanDuoc))
                        {
                            khongCoTrongDanhSach = 1;
                        }
                    }
                    if (khongCoTrongDanhSach == 0)
                    {
                        string toi = "@" + tenDangNhapTextBox.Text;
                        if (!toi.Equals(chuoiNhanDuoc))
                        {
                            listBox1.Items.Add(chuoiNhanDuoc);
                        }
                    }
                }
                else
                {
                    chatRichTextBox.AppendText(chuoiNhanDuoc + "\n");
                }
                _clientSocket.BeginReceive(_receivedBuffer, 0, _receivedBuffer.Length, SocketFlags.None, new AsyncCallback(NhanDuLieu), _clientSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi trong phương thức NhanDuLieu(): " + e.Message);
            }
        }

        private void KetNoiVongLap()
        {
            int soLanThu = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    soLanThu++;
                    _clientSocket.Connect("127.0.0.1", 100);
                }
                catch (SocketException)
                {
                    Console.WriteLine("Số lần thử: " + soLanThu.ToString());
                }
            }

            _clientSocket.BeginReceive(_receivedBuffer, 0, _receivedBuffer.Length, SocketFlags.None, new AsyncCallback(NhanDuLieu), _clientSocket);
            byte[] buffer = Encoding.UTF8.GetBytes("@@" + tenDangNhapTextBox.Text);
            _clientSocket.Send(buffer);
            trangThaiKetNoiLabel.Text = ("Đã kết nối với máy chủ!");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread ketNoiThread = new Thread(KetNoiVongLap);
            ketNoiThread.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected)
            {
                string khachHangDuocChon = "";
                foreach (var item in listBox1.SelectedItems)
                {
                    khachHangDuocChon = listBox1.GetItemText(item);
                    byte[] buffer = Encoding.UTF8.GetBytes(khachHangDuocChon + " :" + tinNhanTextBox.Text + "*" + tenDangNhapTextBox.Text);
                    _clientSocket.Send(buffer);
                    Thread.Sleep(20);
                }
                if (khachHangDuocChon.Equals(""))
                {
                    MessageBox.Show("Vui lòng chọn một giá trị từ danh sách.");
                }
                else
                {
                    chatRichTextBox.AppendText(tenDangNhapTextBox.Text + ": " + tinNhanTextBox.Text + "\n");
                }
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
