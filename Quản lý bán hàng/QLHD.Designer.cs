namespace Quản_lý_bán_hàng
{
    partial class QLHD
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
            QuayLaibtn = new Button();
            QLHDData = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            HuyHoaDonbtn = new Button();
            XemDoanhThubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)QLHDData).BeginInit();
            SuspendLayout();
            // 
            // QuayLaibtn
            // 
            QuayLaibtn.Location = new Point(849, 405);
            QuayLaibtn.Margin = new Padding(2);
            QuayLaibtn.Name = "QuayLaibtn";
            QuayLaibtn.Size = new Size(139, 76);
            QuayLaibtn.TabIndex = 0;
            QuayLaibtn.Text = "Quay lại";
            QuayLaibtn.UseVisualStyleBackColor = true;
            QuayLaibtn.Click += QuayLaibtn_Click;
            // 
            // QLHDData
            // 
            QLHDData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QLHDData.Location = new Point(38, 43);
            QLHDData.Margin = new Padding(2);
            QLHDData.Name = "QLHDData";
            QLHDData.ReadOnly = true;
            QLHDData.RowHeadersWidth = 62;
            QLHDData.RowTemplate.Height = 33;
            QLHDData.Size = new Size(950, 331);
            QLHDData.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(695, 405);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(139, 76);
            button1.TabIndex = 4;
            button1.Text = "Xem chi tiết hóa đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(539, 405);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(139, 76);
            button2.TabIndex = 5;
            button2.Text = "Duyệt hóa đơn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HuyHoaDonbtn
            // 
            HuyHoaDonbtn.Location = new Point(383, 405);
            HuyHoaDonbtn.Margin = new Padding(2);
            HuyHoaDonbtn.Name = "HuyHoaDonbtn";
            HuyHoaDonbtn.Size = new Size(139, 76);
            HuyHoaDonbtn.TabIndex = 6;
            HuyHoaDonbtn.Text = "Hủy  hóa đơn";
            HuyHoaDonbtn.UseVisualStyleBackColor = true;
            HuyHoaDonbtn.Click += HuyHoaDonbtn_Click;
            // 
            // XemDoanhThubtn
            // 
            XemDoanhThubtn.Location = new Point(225, 405);
            XemDoanhThubtn.Margin = new Padding(2);
            XemDoanhThubtn.Name = "XemDoanhThubtn";
            XemDoanhThubtn.Size = new Size(139, 76);
            XemDoanhThubtn.TabIndex = 7;
            XemDoanhThubtn.Text = "Xem doanh thu";
            XemDoanhThubtn.UseVisualStyleBackColor = true;
            XemDoanhThubtn.Click += XemDoanhThubtn_Click;
            // 
            // QLHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 518);
            Controls.Add(XemDoanhThubtn);
            Controls.Add(HuyHoaDonbtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(QLHDData);
            Controls.Add(QuayLaibtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "QLHD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hóa đơn";
            Load += QLHD_Load;
            ((System.ComponentModel.ISupportInitialize)QLHDData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button QuayLaibtn;
        private DataGridView QLHDData;
        private Button button1;
        private Button button2;
        private Button HuyHoaDonbtn;
        private Button XemDoanhThubtn;
    }
}