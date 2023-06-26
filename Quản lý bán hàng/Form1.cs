
using System.Data;
using System.Data.SqlClient;

namespace Quản_lý_bán_hàng
{


    public partial class Form1 : Form
    {

        public static String MAQL;
        public Form1()
        {
            InitializeComponent();

        }

        private void DangNhapbtn_Click(object sender, EventArgs e)
        {
            if (TenDNtxb.Text != null && MatKhautxb.Text != null && (IsKhachHang.Checked == true || IsQuanLy.Checked == true))
            {
                using (SqlConnection connection = new SqlConnection(ManHinhMuaSam.ConnectionString))
                {
                    connection.Open();
                    String ProcedureName = "";
                    if (IsKhachHang.Checked == true)
                    {
                        ProcedureName = "GetKhachHang";
                    }
                    else if (IsQuanLy.Checked == true)
                    {
                        ProcedureName = "GetQuanLy";

                    }
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string taiKhoan = TenDNtxb.Text; // Lấy tài khoản từ TextBox
                        string matKhau = MatKhautxb.Text; // Lấy mật khẩu từ TextBox

                        command.CommandType = CommandType.StoredProcedure;

                        // Đặt các tham số của stored procedure
                        command.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar, 50).Value = taiKhoan;
                        command.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 50).Value = matKhau;

                        // Thiết lập CommandText
                        command.CommandText = ProcedureName;

                        SqlDataReader result = command.ExecuteReader();


                        if (result.Read())
                        {

                            // Tài khoản và mật khẩu hợp lệ
                            if (IsQuanLy.Checked == true)
                            {
                                this.Hide();
                                Form1.MAQL = result[0].ToString();
                                ManHinhQuanLy Form = new ManHinhQuanLy(ManHinhMuaSam.ConnectionString);
                                Form.ShowDialog();

                                this.Show();

                            }
                            else if (IsKhachHang.Checked == true)
                            {
                                ManHinhMuaSam.ThongTinKhachHang.Clear();
                                ManHinhMuaSam.ThongTinKhachHang.Add(result[0].ToString());
                                ManHinhMuaSam.ThongTinKhachHang.Add(result[1].ToString());
                                ManHinhMuaSam.ThongTinKhachHang.Add(result[2].ToString());
                                ManHinhMuaSam.ThongTinKhachHang.Add(result[3].ToString());
                                ManHinhMuaSam.ThongTinKhachHang.Add(result[4].ToString());
                                ManHinhMuaSam.dangnhap = true;
                                this.Close();
                            }
                        }
                        else
                        {
                            // Tài khoản hoặc mật khẩu không hợp lệ
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn cần cung cấp đầy đủ thông tin đăng nhập để tiếp tục");
            }
        }

        private void TaoTaiKhoanbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaoTaiKhoan Form = new(ManHinhMuaSam.ConnectionString);
            Form.ShowDialog();
            this.Show();
        }
    }
}