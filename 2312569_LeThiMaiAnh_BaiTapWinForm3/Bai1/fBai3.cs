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
    public partial class fBai3 : Form
    {
        public fBai3()
        {
            InitializeComponent();
        }

       

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int n = int.Parse(txtSoN.Text);
            int kq = 0;

            if (rdTinhSoTongAB.Checked)
            {
                Cau3.CongHaiSo(a, b, ref kq);
            }
            else
            {
                kq = Cau3.TongDaySo(n);
            }

            lblKetQua.Text = kq.ToString();
        }
    }
}
