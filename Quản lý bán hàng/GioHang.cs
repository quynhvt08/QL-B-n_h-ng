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
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Thoatbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DatHangbtn_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(SoLuonglb.Text) <= 0)
            {
                MessageBox.Show("Không thể đặt hàng");
                return;
            }
            if(ManHinhMuaSam.dangnhap == false)
            {

                MessageBox.Show("Bạn vui lòng đăng nhập để tiếp tục");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn đặt hàng?",
                    "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                HoaDon hd = new ();
                int rowCount = 0;
                using (SqlConnection connection = new SqlConnection(ManHinhMuaSam.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM HoaDon";
                    SqlCommand command = new SqlCommand(query, connection);

                    rowCount = (int)command.ExecuteScalar();
                }

                hd.GetTen().Text = ManHinhMuaSam.ThongTinKhachHang[1];
                hd.GetSDT().Text = ManHinhMuaSam.ThongTinKhachHang[2];
                hd.GetDiaChi().Text = ManHinhMuaSam.ThongTinKhachHang[3];
                hd.GetNgay().Text = DateTime.Now.ToString();
                hd.getTongTien().Text =TongTienlb.Text;
                hd.GetMaKH().Text = ManHinhMuaSam.ThongTinKhachHang[0];
                hd.GetTrangThai().Text = "Chờ duyệt";
                String MAHD;
                while (true)
                {
                    try
                    {
                        MAHD = "HD" + (rowCount + 1).ToString();
                        // Tạo đối tượng SqlCommand để thực thi stored procedure
                        using (SqlConnection connection = new SqlConnection(ManHinhMuaSam.ConnectionString))
                        {
                            connection.Open();

                            SqlCommand command = new SqlCommand($"INSERT INTO HoaDon VALUES ('{MAHD}','{hd.GetMaKH().Text}',NULL,'{hd.GetNgay().Text}'," +
                                $"N'Chờ duyệt','{hd.getTongTien().Text}' )", connection);

                            // Thực thi stored procedure
                            command.ExecuteNonQuery();
                            break;
                        }
                    }
                    catch
                    {
                        rowCount++;
                    }
                }
                hd.GetMaHD().Text = MAHD;
                foreach (MatHangTrongGio mh in MatHang.NhungMatHangTrongGio)
                {
                    mh.getXoabtn().Enabled = false;
                    hd.GetFlowLayoutPanel().Controls.Add(mh);

                    using (SqlConnection connection = new SqlConnection(ManHinhMuaSam.ConnectionString))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand($"INSERT INTO ChiTietHoaDon VALUES ('{MAHD}','{mh.getMAHH()}','{Convert.ToInt32(mh.getSoLuong().Text)}' )", connection);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();   
                    }
                }

                foreach (MatHangTrongGio mh in MatHang.NhungMatHangTrongGio)
                {

                    using (SqlConnection connection = new SqlConnection(ManHinhMuaSam.ConnectionString))
                    {
                        connection.Open();
                        string Querry = $"SELECT SoLuong FROM HangHoa WHERE MAHH = '{mh.getMAHH()}'";
                        SqlCommand command = new SqlCommand(Querry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        int soluong = 0;
                        if(reader.Read())
                        {
                            soluong = reader.GetInt32(0);
                        }
                        reader.Close();

                        soluong -= Convert.ToInt32(mh.getSoLuong().Text);

                        string updateQuerry = $"UPDATE HangHoa SET SoLuong = {soluong} WHERE MAHH = '{mh.getMAHH()}'";
                        command = new SqlCommand (updateQuerry, connection);
                        // Thực thi stored procedure
                        command.ExecuteNonQuery();
                    }
                }


                MatHang.NhungMatHangTrongGio.Clear();
                this.Hide();
                hd.ShowDialog();
                this.Show();
                TongTienlb.Text = "0";
                SoLuonglb.Text = "0";
            }//end đặt hàng
        }
        public FlowLayoutPanel GetFlowLayoutPanel()
        {
            return flowLayoutPanel1;
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
        }
        public Label getSL()
        {
            return SoLuonglb;
        }
        public Label getTT()
        {
            return TongTienlb;
        }
    }
}
