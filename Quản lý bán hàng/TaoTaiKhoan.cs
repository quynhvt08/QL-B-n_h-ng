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
    public partial class TaoTaiKhoan : Form
    {
        String ConnectionString;
        public TaoTaiKhoan(String ConnectionString)
        {
            InitializeComponent();
            this.ConnectionString = ConnectionString;
        }

        private void TaoTaiKhoanbtn_Click(object sender, EventArgs e)
        {
            if (Hotentxb.Text.Length == 0 ||
               Sdttxb.Text.Length == 0 ||
               DiaChitxb.Text.Length == 0 ||
               TenDNtxb.Text.Length == 0 ||
               MatKhautxb.Text.Length == 0 ||
               NhapLaiMatKhautxb.Text.Length == 0)
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin" +
                   " trước khi tiếp tục"); return;
            }
            if (MatKhautxb.Text != NhapLaiMatKhautxb.Text)
            {
                MessageBox.Show("Mật khẩu bạn nhập không" +
                " khớp, xin vui lòng thử lại");
                return;
            }


            //Kiểm tra trùng tên Đăng nhập
            int rowCount = 0;

            // Kiểm tra trùng tên Đăng nhập
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM KhachHang WHERE TaiKhoan = @TaiKhoan";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TaiKhoan", TenDNtxb.Text);

                rowCount = (int)command.ExecuteScalar();
            }
            if (rowCount == 1 ) {
                MessageBox.Show("Tên Đăng Nhập đã tồn tại, vui lòng chọn tên khác");
                return;
            }



            String MAKH;
            //Tự động gán mã Khách Hàng
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM KhachHang";
                SqlCommand command = new SqlCommand(query, connection);

                rowCount = (int)command.ExecuteScalar();
            }



            while(true)
            {
                try
                {
                    MAKH = "KH" + (rowCount + 1).ToString();
                    // Tạo đối tượng SqlCommand để thực thi stored procedure
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("InsertKhachHang", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        command.Parameters.AddWithValue("@MAKH", MAKH);
                        command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = Hotentxb.Text;
                        command.Parameters.AddWithValue("@SDT", Sdttxb.Text);
                        command.Parameters.AddWithValue("@DiaChi", DiaChitxb.Text);
                        command.Parameters.AddWithValue("@TaiKhoan", TenDNtxb.Text);
                        command.Parameters.AddWithValue("@MatKhau", MatKhautxb.Text);

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();



                        MessageBox.Show("Tạo tài khoản thành công,vui lòng quay trở về màn hình đăng nhập");

                        break;
                    }
                }
                catch
                {
                    rowCount++;
                }
            }
           

        }

        private void QuayLaibtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
