using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class fBai4 : Form
    {
        public fBai4()
        {
            InitializeComponent();
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void fBai4_Load(object sender, EventArgs e)
        {

        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            
            foreach(var i in listBox1.Items)
            {
                if (i.ToString() == txtSoCanTim.Text)
                {
                    lblHienThiKetQua.Text = "Tìm thấy";
                    break;
                }
                
                else lblHienThiKetQua.Text = "Không tìm thấy";

            }
        }
    }
}
