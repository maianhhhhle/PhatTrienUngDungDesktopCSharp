using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fBai1 fBai1 = new fBai1();
            fBai1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fBai2 fBai2 = new fBai2();
            fBai2 .ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fBai3 fBai3 = new fBai3();  
            fBai3.ShowDialog();
        }
    }
}
