namespace Quản_lý_bán_hàng
{
    partial class QLHH
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
            QLHHData = new DataGridView();
            CapNhatbtn = new Button();
            XoaHangHoabtn = new Button();
            ((System.ComponentModel.ISupportInitialize)QLHHData).BeginInit();
            SuspendLayout();
            // 
            // QuayLaibtn
            // 
            QuayLaibtn.Location = new Point(1131, 534);
            QuayLaibtn.Name = "QuayLaibtn";
            QuayLaibtn.Size = new Size(132, 91);
            QuayLaibtn.TabIndex = 1;
            QuayLaibtn.Text = "Quay lại";
            QuayLaibtn.UseVisualStyleBackColor = true;
            QuayLaibtn.Click += QuayLaibtn_Click;
            // 
            // QLHHData
            // 
            QLHHData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QLHHData.Location = new Point(32, 56);
            QLHHData.Name = "QLHHData";
            QLHHData.RowHeadersWidth = 62;
            QLHHData.RowTemplate.Height = 33;
            QLHHData.Size = new Size(1231, 406);
            QLHHData.TabIndex = 3;
            // 
            // CapNhatbtn
            // 
            CapNhatbtn.Location = new Point(993, 534);
            CapNhatbtn.Name = "CapNhatbtn";
            CapNhatbtn.Size = new Size(132, 91);
            CapNhatbtn.TabIndex = 4;
            CapNhatbtn.Text = "Cập nhật thông tin";
            CapNhatbtn.UseVisualStyleBackColor = true;
            CapNhatbtn.Click += CapNhatbtn_Click;
            // 
            // XoaHangHoabtn
            // 
            XoaHangHoabtn.Location = new Point(855, 534);
            XoaHangHoabtn.Name = "XoaHangHoabtn";
            XoaHangHoabtn.Size = new Size(132, 91);
            XoaHangHoabtn.TabIndex = 5;
            XoaHangHoabtn.Text = "Xóa hàng hóa";
            XoaHangHoabtn.UseVisualStyleBackColor = true;
            XoaHangHoabtn.Click += XoaHangHoabtn_Click;
            // 
            // QLHH
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 660);
            Controls.Add(XoaHangHoabtn);
            Controls.Add(CapNhatbtn);
            Controls.Add(QLHHData);
            Controls.Add(QuayLaibtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QLHH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hàng hóa";
            ((System.ComponentModel.ISupportInitialize)QLHHData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button QuayLaibtn;
        private DataGridView QLHHData;
        private Button CapNhatbtn;
        private Button XoaHangHoabtn;
    }
}