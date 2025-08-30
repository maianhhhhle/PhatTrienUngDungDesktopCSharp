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
    public partial class fBai2 : Form
    {
        public fBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            rbCheckedChange();
        }

        private void rbCheckedChange()
        {
            int n = int.Parse(txtn.Text);
            if (radioButton1.Checked)
            {
                lblHienThiKetQua.Text = TinhTong(n).ToString();
            }
            else
            {
                lblHienThiKetQua.Text = GiaiThua(n).ToString();
            }
        }

        private int TinhTong(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1) return 1;
            return n + TinhTong(n - 1);
        }

        private int GiaiThua(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * GiaiThua(n - 1);
        }
    }
}
