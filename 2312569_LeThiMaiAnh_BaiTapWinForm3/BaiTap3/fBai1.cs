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
    public partial class fBai1 : Form
    {
        public fBai1()
        {
            InitializeComponent();
        }

        private void fBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien("2312569","Le Thi Mai Anh",new DateTime(2000,3,12),2.5,3.4);
            lblHienThiThongTin.Text = nv.HienThi();
        }
    }
}
