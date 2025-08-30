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
    public partial class fBai1 : Form
    {
        public fBai1()
        {
            InitializeComponent();
        }

        private void fBai1_Load(object sender, EventArgs e)
            
        {
            SanPham sp = new SanPham();
            sp.maSP = "AK12";
            sp.tenSP = "ZiYouLang K84";
            sp.loaiSP = "Bàn phím";
            sp.ngaySX = new DateTime(2023, 7, 4);
            lblHienThiThongTin.Text = sp.HienThi();
        }
    }
}
