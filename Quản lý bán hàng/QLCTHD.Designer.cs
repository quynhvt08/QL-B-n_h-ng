namespace Quản_lý_bán_hàng
{
    partial class QLCTHD
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
            QLCTHDData = new DataGridView();
            QuayLaibtn = new Button();
            ((System.ComponentModel.ISupportInitialize)QLCTHDData).BeginInit();
            SuspendLayout();
            // 
            // QLCTHDData
            // 
            QLCTHDData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QLCTHDData.Location = new Point(23, 31);
            QLCTHDData.Margin = new Padding(2);
            QLCTHDData.Name = "QLCTHDData";
            QLCTHDData.ReadOnly = true;
            QLCTHDData.RowHeadersWidth = 62;
            QLCTHDData.RowTemplate.Height = 33;
            QLCTHDData.Size = new Size(765, 245);
            QLCTHDData.TabIndex = 4;
            // 
            // QuayLaibtn
            // 
            QuayLaibtn.Location = new Point(649, 305);
            QuayLaibtn.Margin = new Padding(2);
            QuayLaibtn.Name = "QuayLaibtn";
            QuayLaibtn.Size = new Size(139, 76);
            QuayLaibtn.TabIndex = 5;
            QuayLaibtn.Text = "Quay lại";
            QuayLaibtn.UseVisualStyleBackColor = true;
            QuayLaibtn.Click += QuayLaibtn_Click_1;
            // 
            // QLCTHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 393);
            Controls.Add(QuayLaibtn);
            Controls.Add(QLCTHDData);
            MaximizeBox = false;
            Name = "QLCTHD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLCTHD";
            ((System.ComponentModel.ISupportInitialize)QLCTHDData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView QLCTHDData;
        private Button QuayLaibtn;
    }
}