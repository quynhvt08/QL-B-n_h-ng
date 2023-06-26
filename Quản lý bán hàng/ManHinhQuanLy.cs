using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_hàng
{
    public partial class ManHinhQuanLy : Form
    {
        String ConnectionString;
        public ManHinhQuanLy(String connectionString)
        {
            InitializeComponent();
            this.ConnectionString = connectionString;
        }

        private void QuayLaibtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLKHbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLKH Form = new QLKH(ConnectionString);
            Form.ShowDialog();
            this.Show();
        }

        private void QLHDbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLHD Form = new QLHD(ConnectionString);
            Form.ShowDialog();
            this.Show();
        }

        private void QLHHbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLHH Form = new QLHH(ConnectionString);
            Form.ShowDialog();
            this.Show();
        }
    }
}
