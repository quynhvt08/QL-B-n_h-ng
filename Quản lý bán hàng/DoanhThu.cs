using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_hàng
{
    public partial class DoanhThu : Form
    {
        DataTable dataTable;
        public DoanhThu()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ManHinhMuaSam.ConnectionString))
            {
                conn.Open();
                String querry = "SELECT TONGTIEN, NGAY FROM HoaDon";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int tongtien = 0;
                int soluonghoadon = 0;
                dataTable.Load(reader);
                Ngaycbb.Items.Clear();
                List<string> uniqueItems = new List<string>();
                foreach (DataRow row in dataTable.Rows)
                {
                    string ngaygio = row["NGAY"].ToString();
                    ngaygio = ngaygio.Replace("SA", "AM");
                    ngaygio = ngaygio.Replace("CH", "PM");
                    DateTime ngay = DateTime.ParseExact(ngaygio, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    string ngayFormatted = ngay.ToString("dd/MM/yyyy");
                    row["NGAY"] = ngayFormatted;
                    if (!uniqueItems.Contains(ngayFormatted))
                    {
                        uniqueItems.Add(ngayFormatted);
                        Ngaycbb.Items.Add(ngayFormatted);
                    }
                    soluonghoadon++;
                    tongtien += Convert.ToInt32(row["TONGTIEN"].ToString());
                }
                SLHDlb.Text = soluonghoadon.ToString();
                TongTienlb.Text = tongtien.ToString();
            }
        }

        private void Ngaycbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TongTien = 0, SLHD = 0;

            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["NGAY"].ToString() == Ngaycbb.SelectedItem.ToString())
                {
                    SLHD++;

                    TongTien += Convert.ToInt32(dataRow["TONGTIEN"].ToString());
                }
            }

            TongTienlb.Text = TongTien.ToString();
            SLHDlb.Text = SLHD.ToString();
        }

        private void XTCCNbtn_Click(object sender, EventArgs e)
        {
            int TongTien = 0, SLHD = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {

                SLHD++;
                TongTien += Convert.ToInt32(dataRow["TONGTIEN"].ToString());

            }
            TongTienlb.Text = TongTien.ToString();
            SLHDlb.Text = SLHD.ToString();
        }

        private void Ngaycbb_TextChanged(object sender, EventArgs e)
        {

        }

        private void XNNbtn_Click(object sender, EventArgs e)
        {
            int TongTien = 0, SLHD = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["NGAY"].ToString() == Ngaycbb.Text)
                {
                    SLHD++;
                    TongTien += Convert.ToInt32(dataRow["TONGTIEN"].ToString());
                }


            }
            TongTienlb.Text = TongTien.ToString();
            SLHDlb.Text = SLHD.ToString();
        }
    }
}
