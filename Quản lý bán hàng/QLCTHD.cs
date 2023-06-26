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
    public partial class QLCTHD : Form
    {
        String MAHD;
        public QLCTHD(string mAHD)
        {
            InitializeComponent();
            MAHD = mAHD;
            using (SqlConnection connection = new SqlConnection(ManHinhMuaSam.ConnectionString))
            {
                connection.Open();
                string query = $"SELECT ChiTietHoaDon.MAHD, ChiTietHoaDon.MAHH, HangHoa.Ten, ChiTietHoaDon.SOLUONG " +
                    $"FROM ChiTietHoaDon " +
                    $"JOIN HangHoa ON ChiTietHoaDon.MAHH = HangHoa.MAHH " +
                    $"WHERE ChiTietHoaDon.MAHD = '{MAHD}'";

                // Tạo SqlDataAdapter để lấy dữ liệu từ SQL Server vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu vào DataTable
                adapter.Fill(dataTable);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                QLCTHDData.DataSource = dataTable;

                // Thiết lập AutoSizeMode cho các cột trong DataGridView
                foreach (DataGridViewColumn column in QLCTHDData.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                QLCTHDData.ScrollBars = ScrollBars.Both;

            }
        }

        private void QuayLaibtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuayLaibtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
