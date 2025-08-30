using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class fBai1 : Form
    {
        public fBai1()
        {
            InitializeComponent();
        }

        private void rabXanh_CheckedChanged(object sender, EventArgs e)
        {
            if (rabXanh.Checked)
            {
                txtDonGia.Text = "22000";
            }
        }

        private void rabDo_CheckedChanged(object sender, EventArgs e)
        {
            if (rabDo.Checked)
            {
                txtDonGia.Text = "21000";
            }
        }

        private void rabTrang_CheckedChanged(object sender, EventArgs e)
        {
            if (rabTrang.Checked)
            {
                txtDonGia.Text = "20000";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTienThanhToan = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            lblTienThanhToan.Text = soTienThanhToan.ToString();
        }
    }
}
