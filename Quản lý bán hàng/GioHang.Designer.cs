namespace Quản_lý_bán_hàng
{
    partial class GioHang
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Thoatbtn = new Button();
            DatHangbtn = new Button();
            panel1 = new Panel();
            TongTienlb = new Label();
            SoLuonglb = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(476, 459);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Thoatbtn
            // 
            Thoatbtn.Location = new Point(607, 406);
            Thoatbtn.Name = "Thoatbtn";
            Thoatbtn.Size = new Size(94, 67);
            Thoatbtn.TabIndex = 1;
            Thoatbtn.Text = "Thoát";
            Thoatbtn.UseVisualStyleBackColor = true;
            Thoatbtn.Click += Thoatbtn_Click;
            // 
            // DatHangbtn
            // 
            DatHangbtn.Location = new Point(494, 406);
            DatHangbtn.Name = "DatHangbtn";
            DatHangbtn.Size = new Size(94, 67);
            DatHangbtn.TabIndex = 2;
            DatHangbtn.Text = "Đặt hàng";
            DatHangbtn.UseVisualStyleBackColor = true;
            DatHangbtn.Click += DatHangbtn_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TongTienlb);
            panel1.Controls.Add(SoLuonglb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(494, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 98);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // TongTienlb
            // 
            TongTienlb.AutoSize = true;
            TongTienlb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TongTienlb.Location = new Point(110, 54);
            TongTienlb.Name = "TongTienlb";
            TongTienlb.Size = new Size(28, 28);
            TongTienlb.TabIndex = 3;
            TongTienlb.Text = "Sl";
            // 
            // SoLuonglb
            // 
            SoLuonglb.AutoSize = true;
            SoLuonglb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoLuonglb.Location = new Point(110, 11);
            SoLuonglb.Name = "SoLuonglb";
            SoLuonglb.Size = new Size(28, 28);
            SoLuonglb.TabIndex = 2;
            SoLuonglb.Text = "Sl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Tổng tiền :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "Số lượng :";
            // 
            // GioHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 495);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(DatHangbtn);
            Controls.Add(Thoatbtn);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "GioHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giỏ hàng";
            Load += GioHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button Thoatbtn;
        private Button DatHangbtn;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label SoLuonglb;
        private Label TongTienlb;
    }
}