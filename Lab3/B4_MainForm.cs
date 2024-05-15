using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class B4_MainForm : Form
    {
        // lưu trữ thtin trthai phòng chiếu, thống kê
        Dictionary<string, Dictionary<int, List<string>>> phongChieuTrangThai = new Dictionary<string, Dictionary<int, List<string>>>();
        List<PhimThongKe> phimThongKeList = new List<PhimThongKe>();

        // lớp phim
        class Phim
        {
            public string Ten { get; set; }
            public int GiaVe { get; set; }
            public int[] PhongChieu { get; set; }
        }

        // lớp PTK
        class PhimThongKe
        {
            public string TenPhim { get; set; }
            public int SoLuongVeBanRa { get; set; }
            public int SoLuongVeTon { get; set; }
            public double TiLeVeBanRa { get; set; }
            public double DoanhThu { get; set; }
        }

        public B4_MainForm()
        {
            InitializeComponent();
            LoadPhim();
        }

        // load thông tin về phim
        private void LoadPhim()
        {
            // khởi tạo ds lưu trữ thtin phim
            List<Phim> phims = new List<Phim>();
            // mở tệp input
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(open.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) // đọc từng dòng
                    {
                        string[] parts = line.Split(','); // tách thành các phần bởi dấu phẩy

                        string[] phongChieuParts = parts.Skip(2).ToArray(); // Bỏ qua phần Tên và GiáVé
                        List<int> phongChieuList = new List<int>();

                        foreach (string phongChieu in phongChieuParts)
                        {
                            // tách các phòng chiếu thành từng phần
                            phongChieuList.AddRange(phongChieu.Split(',').Select(int.Parse));
                        }

                        // thêm phim vừa đọc được vào ds phims
                        Phim phim = new Phim
                        {
                            Ten = parts[0],
                            GiaVe = int.Parse(parts[1]),
                            PhongChieu = phongChieuList.ToArray()
                        };
                        phims.Add(phim);
                    }
                }

                comboBox1.DataSource = phims;
                comboBox1.DisplayMember = "Ten";

                foreach (Phim phim in phims)
                {
                    if (phim.PhongChieu != null)
                    {
                        phongChieuTrangThai[phim.Ten] = new Dictionary<int, List<string>>(); // Khởi tạo trạng thái cho từng phim
                        foreach (int phong in phim.PhongChieu)
                        {
                            phongChieuTrangThai[phim.Ten][phong] = new List<string>(); // Khởi tạo trạng thái cho từng phòng chiếu của phim
                        }
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Lấy ra đối tượng Phim được chọn từ comboBox1
            Phim selectedPhim = comboBox1.SelectedItem as Phim;
            //Lấy danh sách các CheckBox từ tất cả trên form
            List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
            int tongTien = 0;
            int giaVe = selectedPhim.GiaVe;
            bool daChonGhe = false;
            int soLuongVeBanRa = 0; // Đếm số lượng ghế được chọn

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    daChonGhe = true;
                    string hangGhe = checkBox.Name.Split('_')[0];
                    int soGhe = int.Parse(checkBox.Name.Split("_")[1]);

                    int phongChieu = (int)comboBox2.SelectedItem;
                    string ghe = hangGhe + soGhe;

                    if (phongChieuTrangThai.ContainsKey(selectedPhim.Ten) && phongChieuTrangThai[selectedPhim.Ten].ContainsKey(phongChieu) && phongChieuTrangThai[selectedPhim.Ten][phongChieu].Contains(ghe))
                    {
                        MessageBox.Show($"Ghế đã được chọn!");
                        return;
                    }

                    phongChieuTrangThai[selectedPhim.Ten][phongChieu].Add(ghe); // Lưu trạng thái ghế đã chọn
                    if (soGhe == 1 || soGhe == 5)
                    {
                        tongTien += giaVe / 2;
                    }
                    else
                    {
                        if (hangGhe.Equals("B"))
                        {
                            tongTien += giaVe * 2;
                        }
                        else
                        {
                            tongTien += giaVe;
                        }
                    }
                    soLuongVeBanRa++; // Tăng số lượng ghế được chọn
                }
            }


            if (!daChonGhe)
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi đặt vé.");
            }
            else
            {
                string tenKhachHang = string.Empty;
                while (string.IsNullOrEmpty(tenKhachHang))
                {
                    tenKhachHang = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên của bạn:", "Nhập tên", "");
                    if (string.IsNullOrEmpty(tenKhachHang))
                    {
                        DialogResult result = MessageBox.Show("Bạn chưa nhập tên. Tiếp tục?", "Cảnh báo", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.Cancel)
                            return;
                    }
                }
                MessageBox.Show($"Tên khách hàng: {tenKhachHang}\nTổng số tiền: {tongTien}");

                // Update thông tin thống kê của phim
                UpdatePhimThongKe(selectedPhim.Ten, tongTien, soLuongVeBanRa);
            }
        }


        private void UpdatePhimThongKe(string tenPhim, int doanhThu, int soLuongVeBanRa)
        {
           
            PhimThongKe phimThongKe = phimThongKeList.FirstOrDefault(p => p.TenPhim == tenPhim);
            if (phimThongKe == null)
            {
                phimThongKe = new PhimThongKe
                {
                    TenPhim = tenPhim,
                    SoLuongVeBanRa = soLuongVeBanRa,
                    SoLuongVeTon = 0,
                    DoanhThu = doanhThu
                };
                phimThongKeList.Add(phimThongKe);
            }
            else
            {
                phimThongKe.SoLuongVeBanRa += soLuongVeBanRa;
                phimThongKe.DoanhThu += doanhThu;
            }

            // Số lượng phòng chiếu
            int soLuongPhongChieu = phimThongKeList.Sum(p => p.SoLuongVeBanRa > 0 ? 1 : 0);

            // Tính toán số lượng vé tồn
            int soLuongVeTon = soLuongPhongChieu * 30 - phimThongKe.SoLuongVeBanRa;
            phimThongKe.SoLuongVeTon = soLuongVeTon > 0 ? soLuongVeTon : 0;

            // Tính toán tỉ lệ vé bán ra
            foreach (PhimThongKe phim in phimThongKeList)
            {
                phim.TiLeVeBanRa = (double)phim.SoLuongVeBanRa / (phim.SoLuongVeBanRa + phim.SoLuongVeTon) * 100;
            }

            // Sắp xếp lại danh sách theo doanh thu giảm dần
            phimThongKeList = phimThongKeList.OrderByDescending(p => p.DoanhThu).ToList();

        }


        // thay đổi lựa chọn trong cbb
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Phim selectedPhim = comboBox1.SelectedItem as Phim;
            comboBox2.DataSource = selectedPhim.PhongChieu;
            label5.Text = selectedPhim.Ten + " | Giá vé: " + selectedPhim.GiaVe.ToString();
        }

        //tải form lên lần đầu
        private void Bai5_Load(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Phim selectedPhim = comboBox1.SelectedItem as Phim;
                label5.Text = selectedPhim.Ten + " | Giá vé: " + selectedPhim.GiaVe.ToString();
            }
        }

        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            // mở chọn nơi lưu và lưu thông tin
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var phim in phimThongKeList)
                    {
                        sw.WriteLine($"Tên phim: {phim.TenPhim}");
                        sw.WriteLine($"Số lượng vé bán ra: {phim.SoLuongVeBanRa}");
                        sw.WriteLine($"Số lượng vé tồn: {phim.SoLuongVeTon}");
                        sw.WriteLine($"Tỉ lệ vé bán ra: {phim.TiLeVeBanRa}%");
                        sw.WriteLine($"Doanh thu: {phim.DoanhThu}");
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Xuất thông tin thành công!");
            }

        }
    }
}
