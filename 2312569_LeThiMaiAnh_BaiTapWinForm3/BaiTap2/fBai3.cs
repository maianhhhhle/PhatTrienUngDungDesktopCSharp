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
    public partial class fBai3 : Form
    {
        public fBai3()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            string s = "";
            Cau3.NoiChuoi(txtHo.Text, txtTen.Text,ref s);
            lblKetQuaGhepChuoi.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long n = long.Parse(txtn.Text);
            lblKetQuaGiaiThua.Text = (Cau3.GiaiThua(n)).ToString();
        }
    }
}
