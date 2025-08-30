using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBai1 fBai1 = new fBai1();
            fBai1.ShowDialog();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBai3 fBai3 = new fBai3();
            fBai3.ShowDialog();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBai2 fBai2 = new fBai2();
            fBai2.ShowDialog();
        }
    }
}
