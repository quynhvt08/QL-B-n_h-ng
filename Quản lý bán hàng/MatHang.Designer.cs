namespace Quản_lý_bán_hàng
{
    partial class MatHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HinhAnhSanPham = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MatHanglb = new Label();
            DonGialb = new Label();
            SlCLlb = new Label();
            ThemVaoGioBtn = new Button();
            SoLuongtxb = new TextBox();
            Thembtn = new Button();
            Botbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)HinhAnhSanPham).BeginInit();
            SuspendLayout();
            // 
            // HinhAnhSanPham
            // 
            HinhAnhSanPham.BorderStyle = BorderStyle.Fixed3D;
            HinhAnhSanPham.Location = new Point(21, 26);
            HinhAnhSanPham.Margin = new Padding(2);
            HinhAnhSanPham.Name = "HinhAnhSanPham";
            HinhAnhSanPham.Size = new Size(228, 127);
            HinhAnhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            HinhAnhSanPham.TabIndex = 0;
            HinhAnhSanPham.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 164);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Mặt hàng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 196);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Đơn giá :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 230);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 3;
            label3.Text = "Số lượng còn lại:";
            // 
            // MatHanglb
            // 
            MatHanglb.AutoSize = true;
            MatHanglb.Location = new Point(111, 164);
            MatHanglb.Margin = new Padding(2, 0, 2, 0);
            MatHanglb.Name = "MatHanglb";
            MatHanglb.Size = new Size(79, 20);
            MatHanglb.TabIndex = 4;
            MatHanglb.Text = "Mặt hàng :";
            // 
            // DonGialb
            // 
            DonGialb.AutoSize = true;
            DonGialb.Location = new Point(111, 196);
            DonGialb.Margin = new Padding(2, 0, 2, 0);
            DonGialb.Name = "DonGialb";
            DonGialb.Size = new Size(79, 20);
            DonGialb.TabIndex = 5;
            DonGialb.Text = "Mặt hàng :";
            // 
            // SlCLlb
            // 
            SlCLlb.AutoSize = true;
            SlCLlb.Location = new Point(152, 230);
            SlCLlb.Margin = new Padding(2, 0, 2, 0);
            SlCLlb.Name = "SlCLlb";
            SlCLlb.Size = new Size(79, 20);
            SlCLlb.TabIndex = 6;
            SlCLlb.Text = "Mặt hàng :";
            // 
            // ThemVaoGioBtn
            // 
            ThemVaoGioBtn.Location = new Point(133, 277);
            ThemVaoGioBtn.Margin = new Padding(2);
            ThemVaoGioBtn.Name = "ThemVaoGioBtn";
            ThemVaoGioBtn.Size = new Size(116, 61);
            ThemVaoGioBtn.TabIndex = 7;
            ThemVaoGioBtn.Text = "Thêm vào giỏ hàng";
            ThemVaoGioBtn.UseVisualStyleBackColor = true;
            ThemVaoGioBtn.Click += ThemVaoGioBtn_Click;
            // 
            // SoLuongtxb
            // 
            SoLuongtxb.BackColor = Color.LemonChiffon;
            SoLuongtxb.Location = new Point(42, 294);
            SoLuongtxb.Margin = new Padding(2);
            SoLuongtxb.Name = "SoLuongtxb";
            SoLuongtxb.Size = new Size(46, 27);
            SoLuongtxb.TabIndex = 8;
            SoLuongtxb.Text = "0";
            SoLuongtxb.TextAlign = HorizontalAlignment.Center;
            // 
            // Thembtn
            // 
            Thembtn.Location = new Point(92, 294);
            Thembtn.Margin = new Padding(2);
            Thembtn.Name = "Thembtn";
            Thembtn.Size = new Size(36, 27);
            Thembtn.TabIndex = 9;
            Thembtn.Text = "+";
            Thembtn.UseVisualStyleBackColor = true;
            Thembtn.Click += Thembtn_Click;
            // 
            // Botbtn
            // 
            Botbtn.Location = new Point(2, 294);
            Botbtn.Margin = new Padding(2);
            Botbtn.Name = "Botbtn";
            Botbtn.Size = new Size(36, 27);
            Botbtn.TabIndex = 10;
            Botbtn.Text = "-";
            Botbtn.UseVisualStyleBackColor = true;
            Botbtn.Click += Botbtn_Click;
            // 
            // MatHang
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Botbtn);
            Controls.Add(Thembtn);
            Controls.Add(SoLuongtxb);
            Controls.Add(ThemVaoGioBtn);
            Controls.Add(SlCLlb);
            Controls.Add(DonGialb);
            Controls.Add(MatHanglb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(HinhAnhSanPham);
            Margin = new Padding(2);
            Name = "MatHang";
            Size = new Size(270, 360);
            ((System.ComponentModel.ISupportInitialize)HinhAnhSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        public PictureBox HinhAnhSanPham;
        public Label MatHanglb;
        public Label DonGialb;
        public Label SlCLlb;
        public Button ThemVaoGioBtn;
        public TextBox SoLuongtxb;
        public Button Thembtn;
        public Button Botbtn;
    }
}
