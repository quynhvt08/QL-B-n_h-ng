using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_hàng
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        public FlowLayoutPanel GetFlowLayoutPanel()
        {
            return flowLayoutPanel1;
        }
        public Label GetTen() { return HoTenlb; }
        public Label GetSDT() { return SDTlb; }
        public Label GetDiaChi() { return DiaChilb; }
        public Label GetNgay() { return Ngaylb; }
        public Label GetTrangThai() { return TrangThailb; }

        private void Thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Label getTongTien() { return TongTienlb; }

        private void SDTlb_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HoTenlb_Click(object sender, EventArgs e)
        {
        }
        public Label GetMaKH() { return MaKHlb; }
        public Label GetMaHD() { return MaHDlb; }
    }
}
