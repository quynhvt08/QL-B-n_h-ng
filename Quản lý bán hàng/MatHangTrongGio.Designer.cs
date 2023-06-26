namespace Quản_lý_bán_hàng
{
    partial class MatHangTrongGio
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
            HinhAnhSP = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TenSanPhamlb = new Label();
            SoLuonglb = new Label();
            TongTienlb = new Label();
            XoaMatHangbtn = new Button();
            Thembtn = new Button();
            Botbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)HinhAnhSP).BeginInit();
            SuspendLayout();
            // 
            // HinhAnhSP
            // 
            HinhAnhSP.BorderStyle = BorderStyle.FixedSingle;
            HinhAnhSP.Location = new Point(12, 14);
            HinhAnhSP.Name = "HinhAnhSP";
            HinhAnhSP.Size = new Size(169, 107);
            HinhAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            HinhAnhSP.TabIndex = 0;
            HinhAnhSP.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(187, 14);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(187, 56);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Số lượng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(187, 96);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 3;
            label3.Text = "Tổng tiền :";
            // 
            // TenSanPhamlb
            // 
            TenSanPhamlb.AutoSize = true;
            TenSanPhamlb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TenSanPhamlb.Location = new Point(233, 14);
            TenSanPhamlb.Name = "TenSanPhamlb";
            TenSanPhamlb.Size = new Size(50, 25);
            TenSanPhamlb.TabIndex = 4;
            TenSanPhamlb.Text = "Tên :";
            // 
            // SoLuonglb
            // 
            SoLuonglb.AutoSize = true;
            SoLuonglb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SoLuonglb.Location = new Point(289, 56);
            SoLuonglb.Name = "SoLuonglb";
            SoLuonglb.Size = new Size(50, 25);
            SoLuonglb.TabIndex = 5;
            SoLuonglb.Text = "Tên :";
            // 
            // TongTienlb
            // 
            TongTienlb.AutoSize = true;
            TongTienlb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TongTienlb.Location = new Point(289, 96);
            TongTienlb.Name = "TongTienlb";
            TongTienlb.Size = new Size(50, 25);
            TongTienlb.TabIndex = 6;
            TongTienlb.Text = "Tên :";
            // 
            // XoaMatHangbtn
            // 
            XoaMatHangbtn.BackColor = Color.OrangeRed;
            XoaMatHangbtn.FlatStyle = FlatStyle.Popup;
            XoaMatHangbtn.Location = new Point(418, 3);
            XoaMatHangbtn.Name = "XoaMatHangbtn";
            XoaMatHangbtn.Size = new Size(37, 36);
            XoaMatHangbtn.TabIndex = 7;
            XoaMatHangbtn.UseVisualStyleBackColor = false;
            XoaMatHangbtn.Click += XoaMatHangbtn_Click;
            // 
            // Thembtn
            // 
            Thembtn.BackColor = Color.LimeGreen;
            Thembtn.FlatStyle = FlatStyle.Popup;
            Thembtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Thembtn.Location = new Point(418, 47);
            Thembtn.Name = "Thembtn";
            Thembtn.Size = new Size(37, 36);
            Thembtn.TabIndex = 8;
            Thembtn.TextImageRelation = TextImageRelation.ImageAboveText;
            Thembtn.UseVisualStyleBackColor = false;
            Thembtn.Click += Thembtn_Click;
            // 
            // Botbtn
            // 
            Botbtn.BackColor = Color.Yellow;
            Botbtn.FlatStyle = FlatStyle.Popup;
            Botbtn.Location = new Point(418, 92);
            Botbtn.Name = "Botbtn";
            Botbtn.Size = new Size(37, 36);
            Botbtn.TabIndex = 9;
            Botbtn.TextImageRelation = TextImageRelation.ImageAboveText;
            Botbtn.UseVisualStyleBackColor = false;
            Botbtn.Click += Botbtn_Click;
            // 
            // MatHangTrongGio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Botbtn);
            Controls.Add(Thembtn);
            Controls.Add(XoaMatHangbtn);
            Controls.Add(TongTienlb);
            Controls.Add(SoLuonglb);
            Controls.Add(TenSanPhamlb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(HinhAnhSP);
            Name = "MatHangTrongGio";
            Size = new Size(458, 137);
            Load += MatHangTrongGio_Load;
            ((System.ComponentModel.ISupportInitialize)HinhAnhSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox HinhAnhSP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label TenSanPhamlb;
        public Label SoLuonglb;
        public Label TongTienlb;
        private Button XoaMatHangbtn;
        private Button Thembtn;
        private Button Botbtn;
    }
}
