namespace Quản_lý_bán_hàng
{
    partial class DoanhThu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Ngaycbb = new ComboBox();
            SLHDlb = new Label();
            TongTienlb = new Label();
            XTCCNbtn = new Button();
            XNNbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 67);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 0;
            label1.Text = "Số lượng hóa đơn :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 104);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 1;
            label2.Text = "Tổng thu nhập :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 9);
            label3.Name = "label3";
            label3.Size = new Size(222, 35);
            label3.TabIndex = 2;
            label3.Text = "Bộ đếm doanh thu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 145);
            label4.Name = "label4";
            label4.Size = new Size(239, 25);
            label4.TabIndex = 3;
            label4.Text = "Xem doanh thu theo ngày :";
            // 
            // Ngaycbb
            // 
            Ngaycbb.FormattingEnabled = true;
            Ngaycbb.Location = new Point(273, 142);
            Ngaycbb.MaxDropDownItems = 5;
            Ngaycbb.Name = "Ngaycbb";
            Ngaycbb.Size = new Size(123, 28);
            Ngaycbb.Sorted = true;
            Ngaycbb.TabIndex = 4;
            Ngaycbb.Text = " Nhập ngày";
            Ngaycbb.SelectedIndexChanged += Ngaycbb_SelectedIndexChanged;
            Ngaycbb.TextChanged += Ngaycbb_TextChanged;
            // 
            // SLHDlb
            // 
            SLHDlb.AutoSize = true;
            SLHDlb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SLHDlb.Location = new Point(197, 67);
            SLHDlb.Name = "SLHDlb";
            SLHDlb.Size = new Size(22, 25);
            SLHDlb.TabIndex = 5;
            SLHDlb.Text = "0";
            // 
            // TongTienlb
            // 
            TongTienlb.AutoSize = true;
            TongTienlb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TongTienlb.Location = new Point(179, 104);
            TongTienlb.Name = "TongTienlb";
            TongTienlb.Size = new Size(22, 25);
            TongTienlb.TabIndex = 6;
            TongTienlb.Text = "0";
            // 
            // XTCCNbtn
            // 
            XTCCNbtn.Location = new Point(28, 183);
            XTCCNbtn.Name = "XTCCNbtn";
            XTCCNbtn.Size = new Size(171, 44);
            XTCCNbtn.TabIndex = 7;
            XTCCNbtn.Text = "Xem tất cả các ngày";
            XTCCNbtn.UseVisualStyleBackColor = true;
            XTCCNbtn.Click += XTCCNbtn_Click;
            // 
            // XNNbtn
            // 
            XNNbtn.Location = new Point(225, 183);
            XNNbtn.Name = "XNNbtn";
            XNNbtn.Size = new Size(171, 44);
            XNNbtn.TabIndex = 8;
            XNNbtn.Text = "Xem ngày này";
            XNNbtn.UseVisualStyleBackColor = true;
            XNNbtn.Click += XNNbtn_Click;
            // 
            // DoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 275);
            Controls.Add(XNNbtn);
            Controls.Add(XTCCNbtn);
            Controls.Add(TongTienlb);
            Controls.Add(SLHDlb);
            Controls.Add(Ngaycbb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoanhThu";
            Load += DoanhThu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Ngaycbb;
        private Label SLHDlb;
        private Label TongTienlb;
        private Button XTCCNbtn;
        private Button XNNbtn;
    }
}