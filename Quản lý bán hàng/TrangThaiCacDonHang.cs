using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_hàng
{
    public partial class TrangThaiCacDonHang : Form
    {
        public TrangThaiCacDonHang()
        {
            InitializeComponent();
        }

        private void Thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public FlowLayoutPanel GetFlowLayoutPanel()
        {
            return flowLayoutPanel1;
        }



        private void Fillter(String filler, bool Tatca = false)
        {
            if (ManHinhMuaSam.TrangThaiList.Count > 0)
            {
                if (Tatca == false)
                {
                    foreach (TrangThaiDonHang dh in flowLayoutPanel1.Controls)
                    {
                        if (dh.getTrangThai().Text == filler)
                        {
                            dh.Visible = true;
                        }
                        else
                        {
                            dh.Visible = false;
                        }
                    }
                }
                else
                {
                    foreach (TrangThaiDonHang dh in flowLayoutPanel1.Controls)
                    {
                        dh.Visible = true;
                    }
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private void DaDuyetOption_CheckedChanged(object sender, EventArgs e)
        {
            if (DaDuyetOption.Checked == true)
            {
                Fillter(DaDuyetOption.Text, false);
            }
        }

        private void DaHuyOption_CheckedChanged(object sender, EventArgs e)
        {
            if (DaHuyOption.Checked == true)
            {
                Fillter(DaHuyOption.Text, false);
            }
        }

        private void TatCaOption_CheckedChanged(object sender, EventArgs e)
        {
            if (TatCaOption.Checked == true)
            {
                Fillter(TatCaOption.Text, true);
            }
        }

        private void ChoDuyetOption_CheckedChanged(object sender, EventArgs e)
        {
            if (ChoDuyetOption.Checked == true)
            {
                Fillter(ChoDuyetOption.Text, false);
            }
        }

        private void CaoNhatOption_CheckedChanged(object sender, EventArgs e)
        {
            if (CaoNhatOption.Checked == true)
            {
                ManHinhMuaSam.TrangThaiList.Sort((a, b) => Convert.ToInt32(a.getTongTien().Text) > Convert.ToInt32(b.getTongTien().Text) ? -1 : 1);
                for (int i = 0; i < ManHinhMuaSam.TrangThaiList.Count; i++)
                {
                    flowLayoutPanel1.Controls.SetChildIndex(ManHinhMuaSam.TrangThaiList[i], i);
                }
            }
        }

        private void ThapNhatOption_CheckedChanged(object sender, EventArgs e)
        {
            ManHinhMuaSam.TrangThaiList.Sort((a, b) => Convert.ToInt32(a.getTongTien().Text) > Convert.ToInt32(b.getTongTien().Text) ? 1 : -1);
            for (int i = 0; i < ManHinhMuaSam.TrangThaiList.Count; i++)
            {
                flowLayoutPanel1.Controls.SetChildIndex(ManHinhMuaSam.TrangThaiList[i], i);
            }
        }

        private void MoiNhatOption_CheckedChanged(object sender, EventArgs e)
        {
            ManHinhMuaSam.TrangThaiList.Sort((a, b) => DayTimeParse(a.getNgay().Text) > DayTimeParse(b.getNgay().Text) ? -1 : 1);
            for (int i = 0; i < ManHinhMuaSam.TrangThaiList.Count; i++)
            {
                flowLayoutPanel1.Controls.SetChildIndex(ManHinhMuaSam.TrangThaiList[i], i);
            }
        }

        private void CuNhatOption_CheckedChanged(object sender, EventArgs e)
        {
            ManHinhMuaSam.TrangThaiList.Sort((a, b) => DayTimeParse(a.getNgay().Text) > DayTimeParse(b.getNgay().Text) ? 1 : -1);
            for (int i = 0; i < ManHinhMuaSam.TrangThaiList.Count; i++)
            {
                flowLayoutPanel1.Controls.SetChildIndex(ManHinhMuaSam.TrangThaiList[i], i);
            }
        }
        private DateTime DayTimeParse(String datetime)
        {
            datetime = datetime.Replace("CH", "PM");
            datetime = datetime.Replace("SA", "AM");
            return DateTime.ParseExact(datetime, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

        }
    }
}