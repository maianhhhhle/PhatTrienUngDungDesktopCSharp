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
    public partial class fBai2 : Form
    {
        public fBai2()
        {
            InitializeComponent();
        }


        private void fBai2_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        

        private void rbCheckedChanged()
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = 0;
            if (rbCong.Checked) c = a + b;
            else if (rbTru.Checked) c = a - b;
            else if (rbNhan.Checked) c = a * b;
            else c = a / b;

            lblHienThiKetQua.Text = c.ToString();
        }

        

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            rbCheckedChanged();
        }
    }
}
