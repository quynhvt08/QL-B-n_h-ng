namespace Quản_lý_bán_hàng
{
    partial class QLKH
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
            QLKHData = new DataGridView();
            CapNhatbtn = new Button();
            XoaKhachHang = new Button();
            ((System.ComponentModel.ISupportInitialize)QLKHData).BeginInit();
            SuspendLayout();
            // 
            // QuayLaibtn
            // 
            QuayLaibtn.Location = new Point(992, 537);
            QuayLaibtn.Name = "QuayLaibtn";
            QuayLaibtn.Size = new Size(132, 89);
            QuayLaibtn.TabIndex = 1;
            QuayLaibtn.Text = "Quay lại";
            QuayLaibtn.UseVisualStyleBackColor = true;
            QuayLaibtn.Click += QuayLaibtn_Click;
            // 
            // QLKHData
            // 
            QLKHData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QLKHData.Location = new Point(21, 78);
            QLKHData.Name = "QLKHData";
            QLKHData.RowHeadersWidth = 62;
            QLKHData.RowTemplate.Height = 33;
            QLKHData.Size = new Size(1069, 406);
            QLKHData.TabIndex = 2;
            // 
            // CapNhatbtn
            // 
            CapNhatbtn.Location = new Point(839, 537);
            CapNhatbtn.Name = "CapNhatbtn";
            CapNhatbtn.Size = new Size(132, 91);
            CapNhatbtn.TabIndex = 3;
            CapNhatbtn.Text = "Cập nhật thông tin";
            CapNhatbtn.UseVisualStyleBackColor = true;
            CapNhatbtn.Click += CapNhatbtn_Click;
            // 
            // XoaKhachHang
            // 
            XoaKhachHang.Location = new Point(685, 537);
            XoaKhachHang.Name = "XoaKhachHang";
            XoaKhachHang.Size = new Size(132, 91);
            XoaKhachHang.TabIndex = 4;
            XoaKhachHang.Text = "Xóa khách hàng";
            XoaKhachHang.UseVisualStyleBackColor = true;
            XoaKhachHang.Click += XoaKhachHang_Click;
            // 
            // QLKH
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 663);
            Controls.Add(XoaKhachHang);
            Controls.Add(CapNhatbtn);
            Controls.Add(QLKHData);
            Controls.Add(QuayLaibtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QLKH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)QLKHData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button QuayLaibtn;
        private DataGridView QLKHData;
        private Button CapNhatbtn;
        private Button XoaKhachHang;
    }
}