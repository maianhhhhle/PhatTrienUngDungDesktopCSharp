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
    public partial class fBai3 : Form
    {
        public fBai3()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNam.Checked) 
                Cau3.ChaoHoi(txtHoTen.Text, true);
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNu.Checked)
                Cau3.ChaoHoi(txtHoTen.Text,false);
        }

        

        private void btnTim_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtm.Text);
            int n = int.Parse(txtn.Text);
            int kq = Cau3.USCLN(m, n);
            lblKetQua.Text = kq.ToString();
        }
    }
}
