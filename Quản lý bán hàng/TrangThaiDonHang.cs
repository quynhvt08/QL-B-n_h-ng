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
    public partial class TrangThaiDonHang : UserControl
    {
        public TrangThaiDonHang()
        {
            InitializeComponent();
        }

        private void TrangThaiDonHang_Load(object sender, EventArgs e)
        {

        }

        private void XemChiTietbtn_Click(object sender, EventArgs e)
        {
            HoaDon hd = new();
            using (SqlConnection connection = new SqlConnection(ManHinhMuaSam.ConnectionString))
            {
                connection.Open();
                string query = $"SELECT HoaDon.MAHD, HoaDon.MAKH, HoaDon.NGAY, HoaDon.TONGTIEN, HoaDon.Duyet, " +
               $"KhachHang.HoTen, KhachHang.SDT, KhachHang.DiaChi " +
               $"FROM HoaDon INNER JOIN KhachHang ON HoaDon.MAKH = KhachHang.MAKH " +
               $"WHERE HoaDon.MAHD = '{MAHDlb.Text}' " +
               $"AND KhachHang.MAKH = '{ManHinhMuaSam.ThongTinKhachHang[0]}'";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    hd.GetMaHD().Text = reader[0].ToString();
                    hd.GetMaKH().Text = reader[1].ToString();
                    hd.GetNgay().Text = reader[2].ToString();
                    hd.getTongTien().Text = reader[3].ToString();
                    hd.GetTrangThai().Text = reader[4].ToString();
                    hd.GetTen().Text = reader[5].ToString();
                    hd.GetSDT().Text = reader[6].ToString();
                    hd.GetDiaChi().Text = reader[7].ToString();
                }
                reader.Close();
            }

            List<List<String>> Data = new();
            using (SqlConnection connection1 = new SqlConnection(ManHinhMuaSam.ConnectionString))
            {
                connection1.Open();
                String Querry = $"SELECT MAHH, SOLUONG FROM ChiTietHoaDon WHERE MAHD = '{hd.GetMaHD().Text}'";
                SqlCommand cmd = new SqlCommand(Querry, connection1);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    List<String> data = new List<String>();
                    data.Add(reader[0].ToString());
                    data.Add(reader[1].ToString());
                    Data.Add(data);
                }
                reader.Close();
            }

            for (int i = 0; i < Data.Count; i++)
            {
                using (SqlConnection connection1 = new SqlConnection(ManHinhMuaSam.ConnectionString))
                {
                    connection1.Open();
                    String Querry = $"SELECT Ten, DonGia, HinhAnh FROM HangHoa WHERE MAHH = '{Data[i][0]}'";
                    SqlCommand cmd = new SqlCommand(Querry, connection1);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Data[i].Add(reader[0].ToString());
                        Data[i].Add(reader[1].ToString());
                        Data[i].Add(reader[2].ToString());
                    }
                    reader.Close();
                }
                MatHangTrongGio mh = new(Data[i][0], Data[i][2], Data[i][1], Data[i][3], Data[i][4]);
                mh.getXoabtn().Visible = false;
                mh.getThembtn().Visible = false;
                mh.getBotbtn().Visible = false; 
                hd.GetFlowLayoutPanel().Controls.Add(mh);
            }

            this.Hide();
            hd.ShowDialog();
            this.Show();
        }
        public Label getMAHD() { return MAHDlb; }
        public Label getTongTien() { return TongTienlb; }
        public Label getTrangThai() { return TrangThailb; }
        public Label getNgay() { return Ngaylb; }
    }
}
