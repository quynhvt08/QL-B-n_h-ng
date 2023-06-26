namespace Quản_lý_bán_hàng
{
    partial class TrangThaiCacDonHang
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
            button2 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            TatCaOption = new RadioButton();
            DaHuyOption = new RadioButton();
            DaDuyetOption = new RadioButton();
            ChoDuyetOption = new RadioButton();
            label2 = new Label();
            panel1 = new Panel();
            ThapNhatOption = new RadioButton();
            CaoNhatOption = new RadioButton();
            CuNhatOption = new RadioButton();
            MoiNhatOption = new RadioButton();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(26, 17);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(494, 459);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Thoatbtn
            // 
            Thoatbtn.Location = new Point(526, 400);
            Thoatbtn.Name = "Thoatbtn";
            Thoatbtn.Size = new Size(161, 77);
            Thoatbtn.TabIndex = 2;
            Thoatbtn.Text = "Thoát";
            Thoatbtn.UseVisualStyleBackColor = true;
            Thoatbtn.Click += Thoatbtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(526, 317);
            button2.Name = "button2";
            button2.Size = new Size(161, 77);
            button2.TabIndex = 3;
            button2.Text = "Liên hệ Quản lý";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(522, 17);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 5;
            label1.Text = "Lọc";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TatCaOption);
            panel2.Controls.Add(DaHuyOption);
            panel2.Controls.Add(DaDuyetOption);
            panel2.Controls.Add(ChoDuyetOption);
            panel2.Location = new Point(529, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 94);
            panel2.TabIndex = 7;
            // 
            // TatCaOption
            // 
            TatCaOption.AutoSize = true;
            TatCaOption.Location = new Point(114, 48);
            TatCaOption.Name = "TatCaOption";
            TatCaOption.Size = new Size(70, 24);
            TatCaOption.TabIndex = 3;
            TatCaOption.TabStop = true;
            TatCaOption.Text = "Tất cả";
            TatCaOption.UseVisualStyleBackColor = true;
            TatCaOption.CheckedChanged += TatCaOption_CheckedChanged;
            // 
            // DaHuyOption
            // 
            DaHuyOption.AutoSize = true;
            DaHuyOption.Location = new Point(114, 18);
            DaHuyOption.Name = "DaHuyOption";
            DaHuyOption.Size = new Size(76, 24);
            DaHuyOption.TabIndex = 2;
            DaHuyOption.TabStop = true;
            DaHuyOption.Text = "Đã hủy";
            DaHuyOption.UseVisualStyleBackColor = true;
            DaHuyOption.CheckedChanged += DaHuyOption_CheckedChanged;
            // 
            // DaDuyetOption
            // 
            DaDuyetOption.AutoSize = true;
            DaDuyetOption.Location = new Point(11, 48);
            DaDuyetOption.Name = "DaDuyetOption";
            DaDuyetOption.Size = new Size(90, 24);
            DaDuyetOption.TabIndex = 1;
            DaDuyetOption.TabStop = true;
            DaDuyetOption.Text = "Đã duyệt";
            DaDuyetOption.UseVisualStyleBackColor = true;
            DaDuyetOption.CheckedChanged += DaDuyetOption_CheckedChanged;
            // 
            // ChoDuyetOption
            // 
            ChoDuyetOption.AutoSize = true;
            ChoDuyetOption.Location = new Point(11, 18);
            ChoDuyetOption.Name = "ChoDuyetOption";
            ChoDuyetOption.Size = new Size(97, 24);
            ChoDuyetOption.TabIndex = 0;
            ChoDuyetOption.TabStop = true;
            ChoDuyetOption.Text = "Chờ duyệt";
            ChoDuyetOption.UseVisualStyleBackColor = true;
            ChoDuyetOption.CheckedChanged += ChoDuyetOption_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(526, 158);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 8;
            label2.Text = "Sắp xếp";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ThapNhatOption);
            panel1.Controls.Add(CaoNhatOption);
            panel1.Controls.Add(CuNhatOption);
            panel1.Controls.Add(MoiNhatOption);
            panel1.Location = new Point(529, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 94);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // ThapNhatOption
            // 
            ThapNhatOption.AutoSize = true;
            ThapNhatOption.Location = new Point(114, 48);
            ThapNhatOption.Name = "ThapNhatOption";
            ThapNhatOption.Size = new Size(96, 24);
            ThapNhatOption.TabIndex = 3;
            ThapNhatOption.TabStop = true;
            ThapNhatOption.Text = "Thấp nhất";
            ThapNhatOption.UseVisualStyleBackColor = true;
            ThapNhatOption.CheckedChanged += ThapNhatOption_CheckedChanged;
            // 
            // CaoNhatOption
            // 
            CaoNhatOption.AutoSize = true;
            CaoNhatOption.Location = new Point(114, 18);
            CaoNhatOption.Name = "CaoNhatOption";
            CaoNhatOption.Size = new Size(89, 24);
            CaoNhatOption.TabIndex = 2;
            CaoNhatOption.TabStop = true;
            CaoNhatOption.Text = "Cao nhất";
            CaoNhatOption.UseVisualStyleBackColor = true;
            CaoNhatOption.CheckedChanged += CaoNhatOption_CheckedChanged;
            // 
            // CuNhatOption
            // 
            CuNhatOption.AutoSize = true;
            CuNhatOption.Location = new Point(11, 48);
            CuNhatOption.Name = "CuNhatOption";
            CuNhatOption.Size = new Size(80, 24);
            CuNhatOption.TabIndex = 1;
            CuNhatOption.TabStop = true;
            CuNhatOption.Text = "Cũ nhất";
            CuNhatOption.UseVisualStyleBackColor = true;
            CuNhatOption.CheckedChanged += CuNhatOption_CheckedChanged;
            // 
            // MoiNhatOption
            // 
            MoiNhatOption.AutoSize = true;
            MoiNhatOption.Location = new Point(11, 18);
            MoiNhatOption.Name = "MoiNhatOption";
            MoiNhatOption.Size = new Size(89, 24);
            MoiNhatOption.TabIndex = 0;
            MoiNhatOption.TabStop = true;
            MoiNhatOption.Text = "Mới nhất";
            MoiNhatOption.UseVisualStyleBackColor = true;
            MoiNhatOption.CheckedChanged += MoiNhatOption_CheckedChanged;
            // 
            // TrangThaiCacDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 489);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(Thoatbtn);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "TrangThaiCacDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangThaiCacDonHang";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button Thoatbtn;
        private Button button2;
        private Label label1;
        private Panel panel2;
        private RadioButton DaDuyetOption;
        private RadioButton ChoDuyetOption;
        private RadioButton TatCaOption;
        private RadioButton DaHuyOption;
        private Label label2;
        private Panel panel1;
        private RadioButton ThapNhatOption;
        private RadioButton CaoNhatOption;
        private RadioButton CuNhatOption;
        private RadioButton MoiNhatOption;
    }
}