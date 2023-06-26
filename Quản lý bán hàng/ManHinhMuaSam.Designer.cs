namespace Quản_lý_bán_hàng
{
    partial class ManHinhMuaSam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            TenKH = new Label();
            label1 = new Label();
            panel2 = new Panel();
            TimKienbtn = new Button();
            TimKiemtxb = new TextBox();
            DangNhapbtn = new Button();
            Thoatbtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ExitBtn = new Button();
            XemGioHangbtn = new Button();
            XemTrangThaiCacDonHang = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Controls.Add(TenKH);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1603, 81);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // TenKH
            // 
            TenKH.AutoSize = true;
            TenKH.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            TenKH.Location = new Point(1354, 21);
            TenKH.Name = "TenKH";
            TenKH.Size = new Size(73, 31);
            TenKH.TabIndex = 1;
            TenKH.Text = "label2";
            TenKH.Click += TenKH_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 35);
            label1.TabIndex = 0;
            label1.Text = "Mua sắm trực tuyến";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(TimKienbtn);
            panel2.Controls.Add(TimKiemtxb);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 81);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1603, 60);
            panel2.TabIndex = 1;
            // 
            // TimKienbtn
            // 
            TimKienbtn.ImageAlign = ContentAlignment.MiddleLeft;
            TimKienbtn.Location = new Point(57, 17);
            TimKienbtn.Name = "TimKienbtn";
            TimKienbtn.Size = new Size(116, 27);
            TimKienbtn.TabIndex = 3;
            TimKienbtn.Text = "Tìm kiếm";
            TimKienbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            TimKienbtn.UseVisualStyleBackColor = true;
            TimKienbtn.Click += TimKienbtn_Click;
            // 
            // TimKiemtxb
            // 
            TimKiemtxb.Location = new Point(179, 17);
            TimKiemtxb.Name = "TimKiemtxb";
            TimKiemtxb.Size = new Size(311, 27);
            TimKiemtxb.TabIndex = 0;
            TimKiemtxb.TextChanged += TimKiemtxb_TextChanged;
            // 
            // DangNhapbtn
            // 
            DangNhapbtn.Location = new Point(1392, 146);
            DangNhapbtn.Name = "DangNhapbtn";
            DangNhapbtn.Size = new Size(211, 71);
            DangNhapbtn.TabIndex = 2;
            DangNhapbtn.Text = "Đăng nhập";
            DangNhapbtn.UseVisualStyleBackColor = true;
            DangNhapbtn.Click += DangNhapbtn_Click;
            // 
            // Thoatbtn
            // 
            Thoatbtn.Location = new Point(2474, 1041);
            Thoatbtn.Margin = new Padding(2);
            Thoatbtn.Name = "Thoatbtn";
            Thoatbtn.Size = new Size(132, 85);
            Thoatbtn.TabIndex = 2;
            Thoatbtn.Text = "Thoát";
            Thoatbtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(12, 146);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1380, 720);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(1437, 782);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(125, 84);
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "Thoát";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // XemGioHangbtn
            // 
            XemGioHangbtn.ImageAlign = ContentAlignment.MiddleLeft;
            XemGioHangbtn.Location = new Point(1392, 223);
            XemGioHangbtn.Name = "XemGioHangbtn";
            XemGioHangbtn.Size = new Size(211, 84);
            XemGioHangbtn.TabIndex = 5;
            XemGioHangbtn.Text = "Xem giỏ hàng";
            XemGioHangbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            XemGioHangbtn.UseVisualStyleBackColor = true;
            XemGioHangbtn.Click += XemGioHangbtn_Click;
            // 
            // XemTrangThaiCacDonHang
            // 
            XemTrangThaiCacDonHang.ImageAlign = ContentAlignment.MiddleLeft;
            XemTrangThaiCacDonHang.Location = new Point(1392, 313);
            XemTrangThaiCacDonHang.Name = "XemTrangThaiCacDonHang";
            XemTrangThaiCacDonHang.Size = new Size(211, 84);
            XemTrangThaiCacDonHang.TabIndex = 6;
            XemTrangThaiCacDonHang.Text = "Xem trạng thái các đơn hàng";
            XemTrangThaiCacDonHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            XemTrangThaiCacDonHang.UseVisualStyleBackColor = true;
            XemTrangThaiCacDonHang.Click += XemTrangThaiCacDonHang_Click;
            // 
            // ManHinhMuaSam
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1603, 878);
            Controls.Add(DangNhapbtn);
            Controls.Add(XemTrangThaiCacDonHang);
            Controls.Add(XemGioHangbtn);
            Controls.Add(ExitBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Thoatbtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "ManHinhMuaSam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mua sắm trực tuyến";
            Load += ManHinhMuaSam_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Thoatbtn;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ExitBtn;
        private Button XemGioHangbtn;
        private Label TenKH;
        private Button XemTrangThaiCacDonHang;
        private Button DangNhapbtn;
        private Button TimKienbtn;
        private TextBox TimKiemtxb;
    }
}