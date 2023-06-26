namespace Quản_lý_bán_hàng
{
    partial class ManHinhQuanLy
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
            QLKHbtn = new Button();
            QLHHbtn = new Button();
            QLHDbtn = new Button();
            QuayLaibtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // QLKHbtn
            // 
            QLKHbtn.Location = new Point(105, 99);
            QLKHbtn.Name = "QLKHbtn";
            QLKHbtn.Size = new Size(201, 81);
            QLKHbtn.TabIndex = 0;
            QLKHbtn.Text = "Quản lý khách hàng";
            QLKHbtn.UseVisualStyleBackColor = true;
            QLKHbtn.Click += QLKHbtn_Click;
            // 
            // QLHHbtn
            // 
            QLHHbtn.Location = new Point(312, 99);
            QLHHbtn.Name = "QLHHbtn";
            QLHHbtn.Size = new Size(201, 81);
            QLHHbtn.TabIndex = 1;
            QLHHbtn.Text = "Quản lý hàng hóa";
            QLHHbtn.UseVisualStyleBackColor = true;
            QLHHbtn.Click += QLHHbtn_Click;
            // 
            // QLHDbtn
            // 
            QLHDbtn.Location = new Point(105, 196);
            QLHDbtn.Name = "QLHDbtn";
            QLHDbtn.Size = new Size(201, 81);
            QLHDbtn.TabIndex = 2;
            QLHDbtn.Text = "Quản lý hóa đơn";
            QLHDbtn.UseVisualStyleBackColor = true;
            QLHDbtn.Click += QLHDbtn_Click;
            // 
            // QuayLaibtn
            // 
            QuayLaibtn.Location = new Point(312, 196);
            QuayLaibtn.Name = "QuayLaibtn";
            QuayLaibtn.Size = new Size(201, 81);
            QuayLaibtn.TabIndex = 3;
            QuayLaibtn.Text = "Quay lại";
            QuayLaibtn.UseVisualStyleBackColor = true;
            QuayLaibtn.Click += QuayLaibtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(241, 26);
            label1.Name = "label1";
            label1.Size = new Size(128, 43);
            label1.TabIndex = 4;
            label1.Text = "Quản Lý";
            // 
            // ManHinhQuanLy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 333);
            Controls.Add(label1);
            Controls.Add(QuayLaibtn);
            Controls.Add(QLHDbtn);
            Controls.Add(QLHHbtn);
            Controls.Add(QLKHbtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ManHinhQuanLy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Màn hình quản lý";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button QLKHbtn;
        private Button QLHHbtn;
        private Button QLHDbtn;
        private Button QuayLaibtn;
        private Label label1;
    }
}