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
    public partial class QLKH : Form
    {
        String ConnectionString;
        public QLKH(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT MAKH,HoTen,SDT,DiaChi FROM KhachHang"; // Thay TenBang bằng tên bảng cần hiển thị dữ liệu

                // Tạo SqlDataAdapter để lấy dữ liệu từ SQL Server vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu vào DataTable
                adapter.Fill(dataTable);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                QLKHData.DataSource = dataTable;

                // Thiết lập AutoSizeMode cho các cột trong DataGridView
                foreach (DataGridViewColumn column in QLKHData.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                QLKHData.ScrollBars = ScrollBars.Both;

            }
        }

        private void QuayLaibtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát ra sẽ hủy các tác vụ đang hoạt động, bạn có muốn thoát?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CapNhatbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = ((DataTable)QLKHData.DataSource);
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE KhachHang SET HoTen = @HoTen, SDT = @SDT, DiaChi = @DiaChi WHERE MAKH = @MAKH";
                    string insertQuery = "INSERT INTO KhachHang (MAKH,HoTen, SDT, DiaChi) VALUES (@MAKH,@HoTen, @SDT, @DiaChi)";

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        foreach (DataGridViewRow row in QLKHData.Rows)
                        {
                            if (row.IsNewRow) // Nếu là dòng mới
                            {
                                // Kiểm tra nếu các giá trị không rỗng
                                if (!string.IsNullOrEmpty(row.Cells["HoTen"].Value?.ToString()) &&
                                    !string.IsNullOrEmpty(row.Cells["SDT"].Value?.ToString()) &&
                                    !string.IsNullOrEmpty(row.Cells["DiaChi"].Value?.ToString()) &&
                                    !string.IsNullOrEmpty(row.Cells["MAKH"].Value?.ToString()))

                                {
                                    DataRow newRow = dataTable.NewRow();
                                    newRow["MAKH"] = row.Cells["MAKH"].Value;
                                    newRow["HoTen"] = row.Cells["HoTen"].Value;
                                    newRow["SDT"] = row.Cells["SDT"].Value;
                                    newRow["DiaChi"] = row.Cells["DiaChi"].Value;
                                    dataTable.Rows.Add(newRow);
                                }
                            }
                            else // Nếu là dòng đã tồn tại
                            {
                                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;
                                dataRow["MAKH"] = row.Cells["MAKH"].Value;
                                dataRow["HoTen"] = row.Cells["HoTen"].Value;
                                dataRow["SDT"] = row.Cells["SDT"].Value;
                                dataRow["DiaChi"] = row.Cells["DiaChi"].Value;
                            }
                        }

                        adapter.UpdateCommand = new SqlCommand(updateQuery, connection);
                        adapter.UpdateCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "HoTen");
                        adapter.UpdateCommand.Parameters.Add("@SDT", SqlDbType.NVarChar, 50, "SDT");
                        adapter.UpdateCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "DiaChi");
                        adapter.UpdateCommand.Parameters.Add("@MAKH", SqlDbType.NVarChar, 10, "MAKH").SourceVersion = DataRowVersion.Original;

                        adapter.InsertCommand = new SqlCommand(insertQuery, connection);
                        adapter.InsertCommand.Parameters.Add("@MAKH", SqlDbType.NVarChar, 50, "MAKH");
                        adapter.InsertCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "HoTen");
                        adapter.InsertCommand.Parameters.Add("@SDT", SqlDbType.NVarChar, 50, "SDT");
                        adapter.InsertCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "DiaChi");

                        adapter.Update(dataTable);
                        dataTable.AcceptChanges();
                    }
                }
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi thực hiện thay đổi," +
                " vui lòng thử lại");
            }

        }

        private void XoaKhachHang_Click(object sender, EventArgs e)
        {
            if (QLKHData.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa Khách Hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Lấy giá trị khóa chính (MAKH) của KhachHang được chọn
                    string maKH = QLKHData.SelectedRows[0].Cells["MAKH"].Value.ToString();

                    // Xóa bản ghi từ CSDL
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM KhachHang WHERE MAKH = @MAKH";
                        SqlCommand command = new SqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@MAKH", maKH);
                        command.ExecuteNonQuery();
                    }

                    // Xóa dòng tương ứng trong DataGridView
                    QLKHData.Rows.RemoveAt(QLKHData.SelectedRows[0].Index);

                    MessageBox.Show("Xóa Khách Hàng thành công.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn KhachHang để xóa.");
            }
        }
    }
}
