namespace Quản_lý_bán_hàng
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TenDNtxb = new TextBox();
            MatKhautxb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            IsKhachHang = new RadioButton();
            IsQuanLy = new RadioButton();
            DangNhapbtn = new Button();
            TaoTaiKhoanbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 35);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            // 
            // TenDNtxb
            // 
            TenDNtxb.Location = new Point(125, 70);
            TenDNtxb.Margin = new Padding(2);
            TenDNtxb.Name = "TenDNtxb";
            TenDNtxb.Size = new Size(205, 27);
            TenDNtxb.TabIndex = 1;
            // 
            // MatKhautxb
            // 
            MatKhautxb.Location = new Point(125, 110);
            MatKhautxb.Margin = new Padding(2);
            MatKhautxb.Name = "MatKhautxb";
            MatKhautxb.PasswordChar = '*';
            MatKhautxb.Size = new Size(205, 27);
            MatKhautxb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 114);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // IsKhachHang
            // 
            IsKhachHang.AutoSize = true;
            IsKhachHang.Checked = true;
            IsKhachHang.Location = new Point(64, 152);
            IsKhachHang.Margin = new Padding(2);
            IsKhachHang.Name = "IsKhachHang";
            IsKhachHang.Size = new Size(107, 24);
            IsKhachHang.TabIndex = 5;
            IsKhachHang.TabStop = true;
            IsKhachHang.Text = "Khách hàng";
            IsKhachHang.UseVisualStyleBackColor = true;
            // 
            // IsQuanLy
            // 
            IsQuanLy.AutoSize = true;
            IsQuanLy.Location = new Point(190, 152);
            IsQuanLy.Margin = new Padding(2);
            IsQuanLy.Name = "IsQuanLy";
            IsQuanLy.Size = new Size(80, 24);
            IsQuanLy.TabIndex = 6;
            IsQuanLy.Text = "Quản lý";
            IsQuanLy.UseVisualStyleBackColor = true;
            // 
            // DangNhapbtn
            // 
            DangNhapbtn.Location = new Point(158, 199);
            DangNhapbtn.Margin = new Padding(2);
            DangNhapbtn.Name = "DangNhapbtn";
            DangNhapbtn.Size = new Size(137, 49);
            DangNhapbtn.TabIndex = 7;
            DangNhapbtn.Text = "Đăng nhập";
            DangNhapbtn.UseVisualStyleBackColor = true;
            DangNhapbtn.Click += DangNhapbtn_Click;
            // 
            // TaoTaiKhoanbtn
            // 
            TaoTaiKhoanbtn.Location = new Point(286, 150);
            TaoTaiKhoanbtn.Margin = new Padding(2);
            TaoTaiKhoanbtn.Name = "TaoTaiKhoanbtn";
            TaoTaiKhoanbtn.Size = new Size(125, 26);
            TaoTaiKhoanbtn.TabIndex = 8;
            TaoTaiKhoanbtn.Text = "Tạo tài khoản";
            TaoTaiKhoanbtn.UseVisualStyleBackColor = true;
            TaoTaiKhoanbtn.Click += TaoTaiKhoanbtn_Click;
            // 
            // Form1
            // 
            AcceptButton = DangNhapbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 271);
            Controls.Add(TaoTaiKhoanbtn);
            Controls.Add(DangNhapbtn);
            Controls.Add(IsQuanLy);
            Controls.Add(IsKhachHang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MatKhautxb);
            Controls.Add(TenDNtxb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mua sắm trực tuyến";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TenDNtxb;
        private TextBox MatKhautxb;
        private Label label2;
        private Label label3;
        private RadioButton IsKhachHang;
        private RadioButton IsQuanLy;
        private Button DangNhapbtn;
        private Button TaoTaiKhoanbtn;
    }
}