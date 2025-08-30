using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bài1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fBai1 formbai1 = new fBai1();
            formbai1.ShowDialog();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBai2 fBai2 = new fBai2();
            fBai2.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            fBai3 fBai3 = new fBai3();
            fBai3.ShowDialog();
        }
    }
}
