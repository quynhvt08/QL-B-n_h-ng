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
    public partial class MatHangTrongGio : UserControl
    {
        String MAHH;
        String Ten;
        String TongTien;
        String SoLuong;
        String HinhAnh;
        string DonGia;

        public MatHangTrongGio(String MAHH, string ten, string soLuong, string dongia, string hinhAnh)
        {
            InitializeComponent();
            this.MAHH = MAHH;
            this.DonGia = dongia;
            Ten = ten;
            SoLuong = soLuong;
            this.TongTien = (Convert.ToInt32(dongia) * Convert.ToInt32(soLuong)).ToString();
            HinhAnh = hinhAnh;

            this.TenSanPhamlb.Text = Ten;
            this.SoLuonglb.Text = SoLuong;
            this.TongTienlb.Text = TongTien;
            this.HinhAnhSP.ImageLocation = HinhAnh;

            XoaMatHangbtn.Image = Image.FromFile("Icon\\Thoat.PNG");
            Thembtn.Image = Image.FromFile("Icon\\Them.PNG");
            Botbtn.Image = Image.FromFile("Icon\\Bot.PNG");
        }
        public String getMAHH()
        {
            return MAHH;
        }
        public Label getTen()
        {
            return TenSanPhamlb;
        }
        public Label getSoLuong()
        {
            return SoLuonglb;
        }
        public Label getTongTien()
        {
            return TongTienlb;
        }
        private void MatHangTrongGio_Load(object sender, EventArgs e)
        {

        }

        private void XoaMatHangbtn_Click(object sender, EventArgs e)
        {
            MatHang.getGioHang().GetFlowLayoutPanel().Controls.Remove(this);
            MatHang.NhungMatHangTrongGio.Remove(this);

            int soluong = 0, tongtien = 0;
            foreach (MatHangTrongGio mh in MatHang.NhungMatHangTrongGio)
            {
                soluong += Convert.ToInt32(mh.getSoLuong().Text);
                tongtien += Convert.ToInt32(mh.getTongTien().Text);
            }
            MatHang.getGioHang().getSL().Text = soluong.ToString();
            MatHang.getGioHang().getTT().Text = tongtien.ToString();

            foreach (MatHang mh in ManHinhMuaSam.CacMatHang)
            {
                if (mh.getMAHH() == this.MAHH)
                {
                    mh.SlCLlb.Text = (Convert.ToInt32(mh.SlCLlb.Text) + Convert.ToInt32(SoLuonglb.Text)).ToString();
                    return;
                }
            }

        }
        public Button getXoabtn()
        {
            return XoaMatHangbtn;
        }
        public Button getThembtn()
        {
            return Thembtn;
        }
        public Button getBotbtn()
        {
            return Botbtn;
        }
        private void Thembtn_Click(object sender, EventArgs e)
        {
            foreach (MatHang mh in ManHinhMuaSam.CacMatHang)
            {
                if (mh.getMAHH() == this.MAHH)
                {
                    if (mh.SlCLlb.Text == "0")
                    {
                        MessageBox.Show("Đã đạt số lượng tối đa của sản phẩm!");
                        return;
                    }
                    else
                    {
                        mh.SlCLlb.Text = (Convert.ToInt32(mh.SlCLlb.Text) - 1).ToString();
                    }
                }
            }
            this.SoLuonglb.Text = (Convert.ToInt32(this.SoLuonglb.Text) + 1).ToString();
            this.TongTienlb.Text = (Convert.ToInt32(this.TongTienlb.Text) + Convert.ToInt32(DonGia)).ToString();
            MatHang.getGioHang().getSL().Text = (Convert.ToInt32(MatHang.getGioHang().getSL().Text) + 1).ToString();
            MatHang.getGioHang().getTT().Text = (Convert.ToInt32(MatHang.getGioHang().getTT().Text) + Convert.ToInt32(DonGia)).ToString();
        }

        private void Botbtn_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(this.SoLuonglb.Text) == 1)
            {
                this.XoaMatHangbtn_Click(sender, e);
                return;
            }
            else
            {
                this.SoLuonglb.Text = (Convert.ToInt32(this.SoLuonglb.Text) - 1).ToString();
                this.TongTienlb.Text = (Convert.ToInt32(this.TongTienlb.Text) - Convert.ToInt32(DonGia)).ToString();
                MatHang.getGioHang().getSL().Text = (Convert.ToInt32(MatHang.getGioHang().getSL().Text) - 1).ToString();
                MatHang.getGioHang().getTT().Text = (Convert.ToInt32(MatHang.getGioHang().getTT().Text) - Convert.ToInt32(DonGia)).ToString();
                foreach (MatHang mh in ManHinhMuaSam.CacMatHang)
                {
                    if (mh.getMAHH() == this.MAHH)
                    {
                        mh.SlCLlb.Text = (Convert.ToInt32(mh.SlCLlb.Text) + 1).ToString();
                        return;
                    }
                }
            }
        }
    }
}
