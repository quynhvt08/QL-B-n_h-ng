using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_hàng
{
    public partial class ManHinhMuaSam : Form
    {
        public static List<MatHang> CacMatHang;
        DataTable data;
        public static List<String> ThongTinKhachHang = new List<string>();
        public static List<TrangThaiDonHang> TrangThaiList = new List<TrangThaiDonHang>();
        public static String ConnectionString = "Data Source=NGIAS;" +
     "Initial Catalog=QuanLyBanHang;" +
     "Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public static bool dangnhap = false;

        public ManHinhMuaSam()
        {
            InitializeComponent();


            string imagePath = "Icon\\Sale.PNG"; // Đường dẫn tới hình ảnh của bạn

            // Đặt thuộc tính img của Panel1 là đường dẫn tới hình ảnh
            panel1.BackgroundImage = Image.FromFile(imagePath);
            TimKienbtn.Image = Image.FromFile("Icon\\Search.PNG");
            // Đặt thuộc tính BackgroundImageLayout của Panel1 là None để hình ảnh chỉ hiển thị một lần và nằm ở góc trái
            panel1.BackgroundImageLayout = ImageLayout.None;
            XemGioHangbtn.Image = Image.FromFile("Icon\\Shopping.PNG");

            CacMatHang = new List<MatHang>();
            data = new DataTable();

            TenKH.Text = string.Empty;
        }

        private void ManHinhMuaSam_Load(object sender, EventArgs e)
        {

            CacMatHang.Clear();
            using (SqlConnection connection = new SqlConnection(ManHinhMuaSam.ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT MAHH, Ten, SoLuong, DonGia,HinhAnh FROM HangHoa";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    // Bây giờ bạn có DataTable "data" chứa dữ liệu từ bảng HangHoa
                    // Bạn có thể sử dụng DataTable này cho các mục đích khác trong ứng dụng của bạn
                    foreach (DataRow row in data.Rows)
                    {

                        MatHang matHang = new MatHang(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                        CacMatHang.Add(matHang);
                        flowLayoutPanel1.Controls.Add(matHang);
                    }

                }
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát ra sẽ không lưu giỏ hàng, bạn có muốn thoát?",
                                "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MatHang.NhungMatHangTrongGio.Clear();
                MatHang.gioHang.GetFlowLayoutPanel().Controls.Clear();

                ThongTinKhachHang.Clear();

                this.Close();
            }
        }

        private void XemGioHangbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = 0, tongtien = 0;
                foreach (MatHangTrongGio mh in MatHang.NhungMatHangTrongGio)
                {
                    soluong += Convert.ToInt32(mh.getSoLuong().Text);
                    tongtien += Convert.ToInt32(mh.getTongTien().Text);
                }
                MatHang.getGioHang().getSL().Text = soluong.ToString();
                MatHang.getGioHang().getTT().Text = tongtien.ToString();
            }
            catch
            {
                MatHang.getGioHang().getSL().Text = "0";
                MatHang.getGioHang().getTT().Text = "0";
            }
            this.Hide();
            MatHang.getGioHang().ShowDialog();
            this.Show();
        }

        private void XemTrangThaiCacDonHang_Click(object sender, EventArgs e)
        {
            if (dangnhap == false)
            {
                MessageBox.Show("Bạn vui lòng đăng nhập để tiếp tục");
                return;
            }
            using (SqlConnection con = new SqlConnection(ManHinhMuaSam.ConnectionString))
            {
                con.Open();
                string querry = $"SELECT MAHD, NGAY, DUYET, TONGTIEN FROM HoaDon WHERE MAKH ='{ManHinhMuaSam.ThongTinKhachHang[0]}'";
                SqlCommand command = new SqlCommand(querry, con);
                SqlDataReader reader = command.ExecuteReader();
                TrangThaiCacDonHang cacdonhang = new();
                TrangThaiList = new List<TrangThaiDonHang>();
                while (reader.Read())
                {
                    TrangThaiDonHang donHang = new();
                    donHang.getMAHD().Text = reader[0].ToString();
                    donHang.getNgay().Text = reader[1].ToString();
                    donHang.getTrangThai().Text = reader[2].ToString();
                    donHang.getTongTien().Text = reader[3].ToString();
                    TrangThaiList.Add(donHang);
                    cacdonhang.GetFlowLayoutPanel().Controls.Add(donHang);
                }
                this.Hide();
                cacdonhang.ShowDialog();
                this.Show();
            }
        }

        private void TenKH_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DangNhapbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new();
            this.Hide();
            f.ShowDialog();
            this.Show();
            if (dangnhap == true)
            {
                MessageBox.Show($"Xin chào {ThongTinKhachHang[1]}!");
                this.TenKH.Text = ThongTinKhachHang[1];
            }
        }

        private void TimKienbtn_Click(object sender, EventArgs e)
        {

        }

        private void TimKiemtxb_TextChanged(object sender, EventArgs e)
        {
            foreach (MatHang mh in CacMatHang)
            {
                if(mh.getTenMH().ToLower().Contains(TimKiemtxb.Text.ToLower()))
                {
                    mh.Visible = true;
                }
                else
                {
                    mh.Visible = false;
                }
            }
        }
    }
}
