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
    public partial class fBai1 : Form
    {
        public fBai1()
        {
            InitializeComponent();
        }

        private void fBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi("m123", "Bàn phím Akko 3098s", "Việt Nam", 999000, 120);
            label2.Text = tb.HienThi();
        }
    }
}
