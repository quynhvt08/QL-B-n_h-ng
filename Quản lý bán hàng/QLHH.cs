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
    public partial class QLHH : Form
    {
        String ConnectionString;
        public QLHH(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM HangHoa"; // Thay TenBang bằng tên bảng cần hiển thị dữ liệu

                // Tạo SqlDataAdapter để lấy dữ liệu từ SQL Server vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu vào DataTable
                adapter.Fill(dataTable);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                QLHHData.DataSource = dataTable;

                // Thiết lập AutoSizeMode cho các cột trong DataGridView
                foreach (DataGridViewColumn column in QLHHData.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                QLHHData.ScrollBars = ScrollBars.Both;

            }
        }

        private void QuayLaibtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát ra sẽ hủy các tác vụ đang hoạt động, bạn có muốn thoát?",
                                "Xác nhận xóa", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CapNhatbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = ((DataTable)QLHHData.DataSource);
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE HangHoa SET Ten = @Ten, SoLuong = @SoLuong, DonGia = @DonGia, HinhAnh = @HinhAnh " +
                                         "WHERE MAHH = @MAHH";
                    string insertQuery = "INSERT INTO HangHoa (MAHH, Ten, SoLuong, DonGia, HinhAnh) " +
                                         "VALUES (@MAHH, @Ten, @SoLuong, @DonGia, @HinhAnh)";

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        foreach (DataGridViewRow row in QLHHData.Rows)
                        {
                            if (row.IsNewRow)
                            {
                                if (!string.IsNullOrEmpty(row.Cells["Ten"].Value?.ToString()) &&
                                    !string.IsNullOrEmpty(row.Cells["SoLuong"].Value?.ToString()) &&
                                    !string.IsNullOrEmpty(row.Cells["DonGia"].Value?.ToString()) &&
                                    !string.IsNullOrEmpty(row.Cells["HinhAnh"].Value?.ToString()))
                                {
                                    DataRow newRow = dataTable.NewRow();
                                    newRow["MAHH"] = row.Cells["MAHH"].Value;
                                    newRow["Ten"] = row.Cells["Ten"].Value;
                                    newRow["SoLuong"] = row.Cells["SoLuong"].Value;
                                    newRow["DonGia"] = row.Cells["DonGia"].Value;
                                    newRow["HinhAnh"] = row.Cells["HinhAnh"].Value;
                                    dataTable.Rows.Add(newRow);
                                }
                            }
                            else
                            {
                                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;
                                dataRow["MAHH"] = row.Cells["MAHH"].Value;
                                dataRow["Ten"] = row.Cells["Ten"].Value;
                                dataRow["SoLuong"] = row.Cells["SoLuong"].Value;
                                dataRow["DonGia"] = row.Cells["DonGia"].Value;
                                dataRow["HinhAnh"] = row.Cells["HinhAnh"].Value;
                            }
                        }

                        adapter.UpdateCommand = new SqlCommand(updateQuery, connection);
                        adapter.UpdateCommand.Parameters.Add("@Ten", SqlDbType.NVarChar, 50, "Ten");
                        adapter.UpdateCommand.Parameters.Add("@SoLuong", SqlDbType.Int, 0, "SoLuong");
                        adapter.UpdateCommand.Parameters.Add("@DonGia", SqlDbType.Int, 0, "DonGia");
                        adapter.UpdateCommand.Parameters.Add("@HinhAnh", SqlDbType.NVarChar, -1, "HinhAnh");
                        adapter.UpdateCommand.Parameters.Add("@MAHH", SqlDbType.NVarChar, 10, "MAHH").SourceVersion = DataRowVersion.Original;

                        adapter.InsertCommand = new SqlCommand(insertQuery, connection);
                        adapter.InsertCommand.Parameters.Add("@MAHH", SqlDbType.NVarChar, 10, "MAHH");
                        adapter.InsertCommand.Parameters.Add("@Ten", SqlDbType.NVarChar, 50, "Ten");
                        adapter.InsertCommand.Parameters.Add("@SoLuong", SqlDbType.Int, 0, "SoLuong");
                        adapter.InsertCommand.Parameters.Add("@DonGia", SqlDbType.Int, 0, "DonGia");
                        adapter.InsertCommand.Parameters.Add("@HinhAnh", SqlDbType.NVarChar, -1, "HinhAnh");

                        adapter.Update(dataTable);
                        dataTable.AcceptChanges();
                    }
                }
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi thực hiện thay đổi, vui lòng thử lại");
            }
        }

        private void XoaHangHoabtn_Click(object sender, EventArgs e)
        {
            if (QLHHData.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa Hàng Hóa này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Lấy giá trị khóa chính (MAHH) của HangHoa được chọn
                    string maHH = QLHHData.SelectedRows[0].Cells["MAHH"].Value.ToString();

                    // Xóa bản ghi từ CSDL
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM HangHoa WHERE MAHH = @MAHH";
                        SqlCommand command = new SqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@MAHH", maHH);
                        command.ExecuteNonQuery();
                    }

                    // Xóa dòng tương ứng trong DataGridView
                    QLHHData.Rows.RemoveAt(QLHHData.SelectedRows[0].Index);

                    MessageBox.Show("Xóa Hàng Hóa thành công.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Hàng Hóa để xóa.");
            }
        }
    }
}
