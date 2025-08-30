using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
        }

        private void bàiSố1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBai1 formBai1 = new fBai1();
            formBai1.ShowDialog();
        }

        private void bàiSố2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBai2 formBai2 = new fBai2();
            formBai2.ShowDialog();
        }

        private void bàiSố3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBai3 fBai3 = new fBai3();
            fBai3 .ShowDialog();
        }
    }
}
