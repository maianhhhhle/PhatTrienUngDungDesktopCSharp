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
    public partial class fFormChinh : Form
    {
        public fFormChinh()
        {
            InitializeComponent();
        }

        private void tsmiBaiTap1_Click(object sender, EventArgs e)
        {
            fBai1 formBai1 = new fBai1();
            formBai1.ShowDialog();
        }

        private void tsmiBaiTap2_Click(object sender, EventArgs e)
        {
            fBai2 formBai2 = new fBai2();
            formBai2.ShowDialog();
        }

        private void tsmiBaiTap3_Click(object sender, EventArgs e)
        {
            fBai3 formBai3 = new fBai3();
            formBai3.ShowDialog();
        }

        private void bàiTập4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBai4 formBai4 = new fBai4();
            formBai4.ShowDialog();
        }
    }
}
