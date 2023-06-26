namespace Quản_lý_bán_hàng
{
    partial class TrangThaiDonHang
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
            label1 = new Label();
            XemChiTietbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            MAHDlb = new Label();
            TongTienlb = new Label();
            TrangThailb = new Label();
            label4 = new Label();
            Ngaylb = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Hóa Đơn :";
            // 
            // XemChiTietbtn
            // 
            XemChiTietbtn.Location = new Point(336, 123);
            XemChiTietbtn.Name = "XemChiTietbtn";
            XemChiTietbtn.Size = new Size(118, 58);
            XemChiTietbtn.TabIndex = 1;
            XemChiTietbtn.Text = "Xem chi tiết";
            XemChiTietbtn.UseVisualStyleBackColor = true;
            XemChiTietbtn.Click += XemChiTietbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 71);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "Tổng tiền :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 115);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 3;
            label3.Text = "Trạng thái :";
            // 
            // MAHDlb
            // 
            MAHDlb.AutoSize = true;
            MAHDlb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MAHDlb.Location = new Point(158, 29);
            MAHDlb.Name = "MAHDlb";
            MAHDlb.Size = new Size(44, 25);
            MAHDlb.TabIndex = 4;
            MAHDlb.Text = "null";
            // 
            // TongTienlb
            // 
            TongTienlb.AutoSize = true;
            TongTienlb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TongTienlb.Location = new Point(132, 71);
            TongTienlb.Name = "TongTienlb";
            TongTienlb.Size = new Size(44, 25);
            TongTienlb.TabIndex = 5;
            TongTienlb.Text = "null";
            // 
            // TrangThailb
            // 
            TrangThailb.AutoSize = true;
            TrangThailb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TrangThailb.Location = new Point(136, 115);
            TrangThailb.Name = "TrangThailb";
            TrangThailb.Size = new Size(44, 25);
            TrangThailb.TabIndex = 6;
            TrangThailb.Text = "null";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 156);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 7;
            label4.Text = "Ngày :";
            // 
            // Ngaylb
            // 
            Ngaylb.AutoSize = true;
            Ngaylb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Ngaylb.Location = new Point(96, 156);
            Ngaylb.Name = "Ngaylb";
            Ngaylb.Size = new Size(44, 25);
            Ngaylb.TabIndex = 8;
            Ngaylb.Text = "null";
            // 
            // TrangThaiDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Ngaylb);
            Controls.Add(label4);
            Controls.Add(TrangThailb);
            Controls.Add(TongTienlb);
            Controls.Add(MAHDlb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(XemChiTietbtn);
            Controls.Add(label1);
            Name = "TrangThaiDonHang";
            Size = new Size(465, 196);
            Load += TrangThaiDonHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button XemChiTietbtn;
        private Label label2;
        private Label label3;
        private Label MAHDlb;
        private Label TongTienlb;
        private Label TrangThailb;
        private Label label4;
        private Label Ngaylb;
    }
}
