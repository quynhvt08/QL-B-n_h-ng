using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_hàng
{
    public partial class MatHang : UserControl
    {
        public static GioHang gioHang = new();
        public static List<MatHangTrongGio> NhungMatHangTrongGio = new();
        String MaHH;
        String Ten;
        String SoLuong;
        String DonGia;
        String HinhAnh;
        public MatHang(string MaHH, string ten, String soLuong, String donGia,string HinhAnh)
        {
            InitializeComponent();
            this.MaHH = MaHH;
            Ten = ten;
            SoLuong = soLuong;
            DonGia = donGia;
            this.HinhAnh = HinhAnh;
            
            HinhAnhSanPham.ImageLocation = HinhAnh;
            HinhAnhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            MatHanglb.Text = Ten;
            SlCLlb.Text = SoLuong;
            DonGialb.Text = DonGia;
        }

        private void ThemVaoGioBtn_Click(object sender, EventArgs e)
        {
            int sl;
            try
            {
                sl = Convert.ToInt32(SoLuongtxb.Text);
                if (sl <= 0 || sl > Convert.ToInt16(SlCLlb.Text))
                {
                    MessageBox.Show("Bạn vui lòng chọn số lượng hợp lệ");
                    SoLuongtxb.Text = "0";
                    return;
                }
            }
            catch {
                MessageBox.Show("Bạn vui lòng chọn số lượng hợp lệ");
                SoLuongtxb.Text = "0";
                return;
            }

            bool added = false;
            foreach(MatHangTrongGio mh in NhungMatHangTrongGio)
            {
                MatHangTrongGio mhh = (MatHangTrongGio)mh;
                if (mhh.getMAHH() == MaHH)
                {
                    Label sluong = mhh.getSoLuong();
                    sluong.Text = (Convert.ToInt16(sluong.Text) + sl).ToString();
                    Label Tongtien = mhh.getTongTien();
                    Tongtien.Text = (Convert.ToInt32(sluong.Text)*Convert.ToInt32(DonGia)).ToString();
                    added = true;
                }
            }
            if(!added)
            {
                MatHangTrongGio matHangTrongGio = new MatHangTrongGio(MaHH, Ten, sl.ToString(), DonGia, HinhAnh);
                gioHang.GetFlowLayoutPanel().Controls.Add(matHangTrongGio);
                NhungMatHangTrongGio.Add(matHangTrongGio);
            }
            MessageBox.Show("Thêm vào giỏ hàng thành công");
            SoLuongtxb.Text = "0";
            SlCLlb.Text = (Convert.ToInt32(SlCLlb.Text) - sl).ToString();
            
           
        }

        private void Thembtn_Click(object sender, EventArgs e)
        {
            try
            {
                SoLuongtxb.Text = (Convert.ToInt16(SoLuongtxb.Text) + 1).ToString();
            }
            catch
            {
                SoLuongtxb.Text = "0";
            }
        }

        private void Botbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SoLuongtxb.Text = (Convert.ToInt16(SoLuongtxb.Text) - 1) >= 0 ?
                                (Convert.ToInt16(SoLuongtxb.Text) - 1).ToString() : "0";
            }
            catch
            {
                SoLuongtxb.Text = "0";
            }
        }
        public static GioHang getGioHang()
        {
            return gioHang;
        }
        public String getMAHH()
        {
            return MaHH;
        }
        public string getTenMH()
        {
            return MatHanglb.Text;
        }
    }
}
