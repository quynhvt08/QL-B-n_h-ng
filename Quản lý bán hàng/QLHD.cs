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
    public partial class QLHD : Form
    {
        String ConnectionString;
        public QLHD(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;

        }

        private void QuayLaibtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QLHDData.SelectedCells.Count > 0)
            {

                DataGridViewRow SelectedRow = QLHDData.SelectedCells[0].OwningRow;
                QLCTHD qlcthd = new QLCTHD(SelectedRow.Cells[0].Value.ToString());
                this.Hide();
                qlcthd.ShowDialog();
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (QLHDData.SelectedCells.Count > 0)
            {

                DataGridViewRow SelectedRow = QLHDData.SelectedCells[0].OwningRow;

                DialogResult result = MessageBox.Show("Bạn có muốn duyệt hóa đơn này chứ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();


                        string checkquerry = $"SELECT DUYET FROM HoaDon WHERE MAHD = '{SelectedRow.Cells[0].Value.ToString()}'";
                        SqlCommand command = new SqlCommand(checkquerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            if (reader.GetString(0) == "Chờ duyệt")
                            {
                                reader.Close();
                                string updateQuery = $"UPDATE HoaDon SET MAQL = '{Form1.MAQL}', DUYET = N'Đã duyệt'" +
                                     $" WHERE MAHD = '{SelectedRow.Cells[0].Value.ToString()}'";
                                command = new SqlCommand(updateQuery, connection);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Đã duyệt thành công hóa đơn");
                                this.QLHD_Load(sender, e);
                                return;
                            }

                        }
                        MessageBox.Show("Không thể duyệt hóa đơn này");
                    }
                }

            }

        }

        private void QLHD_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT MAHD,MAKH,MAQL,NGAY,DUYET,TONGTIEN FROM HoaDon"; // Thay TenBang bằng tên bảng cần hiển thị dữ liệu

                // Tạo SqlDataAdapter để lấy dữ liệu từ SQL Server vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu vào DataTable
                adapter.Fill(dataTable);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                QLHDData.DataSource = dataTable;

                // Thiết lập AutoSizeMode cho các cột trong DataGridView
                foreach (DataGridViewColumn column in QLHDData.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                QLHDData.ScrollBars = ScrollBars.Both;

            }
        }

        private void HuyHoaDonbtn_Click(object sender, EventArgs e)
        {
            if (QLHDData.SelectedCells.Count > 0)
            {

                DataGridViewRow SelectedRow = QLHDData.SelectedCells[0].OwningRow;

                DialogResult result = MessageBox.Show("Bạn có muốn HỦY hóa đơn này chứ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();


                        string checkquerry = $"SELECT DUYET FROM HoaDon WHERE MAHD = '{SelectedRow.Cells[0].Value.ToString()}'";
                        SqlCommand command = new SqlCommand(checkquerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            if (reader.GetString(0) == "Chờ duyệt")
                            {
                                reader.Close();

                                string getSoLuong = $"SELECT MAHH, SOLUONG FROM ChiTietHoaDon WHERE MAHD = '{SelectedRow.Cells[0].Value.ToString()}'";
                                command = new SqlCommand(getSoLuong, connection);
                                SqlDataReader reader2 = command.ExecuteReader();
                                List<List<string>> Data = new();
                                while (reader2.Read())
                                {
                                    List<string> data = new List<string>();
                                    data.Add(reader2.GetString(0));
                                    data.Add(reader2.GetInt32(1).ToString());
                                    Data.Add(data);
                                }
                                reader2.Close();


                                for (int i = 0; i < Data.Count; i++)
                                {
                                    String getSoLuong2 = $"SELECT SoLuong FROM HangHoa WHERE MAHH = '{Data[i][0]}'";
                                    SqlCommand sqlCommand2 = new SqlCommand(getSoLuong2, connection);
                                    SqlDataReader reader3 = sqlCommand2.ExecuteReader();
                                    reader3.Read();
                                    Data[i].Add(reader3.GetInt32(0).ToString());
                                    reader3.Close();
                                }

                                for (int i = 0; i < Data.Count; i++)
                                {
                                    int sl = Convert.ToInt32(Data[i][1]) + Convert.ToInt32(Data[i][2]);
                                    String UpdateQuerry = $"UPDATE HangHoa SET SoLuong = {sl} WHERE MAHH = '{Data[i][0]}'";
                                    SqlCommand com = new SqlCommand(UpdateQuerry, connection);
                                    com.ExecuteNonQuery();
                                }

                                string DeleteQuery1 = $"DELETE FROM ChiTietHoaDon WHERE MAHD = '{SelectedRow.Cells[0].Value.ToString()}'";
                                command = new SqlCommand(DeleteQuery1, connection);
                                command.ExecuteNonQuery();

                                string updateQuery = $"UPDATE HoaDon SET MAQL = '{Form1.MAQL}', DUYET = N'Đã hủy'" +
                                    $" WHERE MAHD = '{SelectedRow.Cells[0].Value.ToString()}'";
                                command = new SqlCommand(updateQuery, connection);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Đã Hủy thành công hóa đơn");
                                this.QLHD_Load(sender, e);
                                return;
                            }

                        }
                        MessageBox.Show("Không thể hủy hóa đơn này");
                    }
                }

            }
        }

        private void XemDoanhThubtn_Click(object sender, EventArgs e)
        {
            DoanhThu d = new();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }
    }
}
