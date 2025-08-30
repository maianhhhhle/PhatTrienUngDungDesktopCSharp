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
    public partial class fBai3 : Form
    {
        public fBai3()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            string s1 = "";
            string s2 = "";
            Cau3.TachChuoi(hoten,ref s1,ref s2);

            lblHo.Text = s1;
            lblTen.Text = s2;
        }

        private void btnKetQua_Click_1(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtn1.Text);
            int n2 = int.Parse(txtn2.Text);
            lblHienThiKetQua.Text = Cau3.ThuTu(n1,n2).ToString();
        }
    }
}
