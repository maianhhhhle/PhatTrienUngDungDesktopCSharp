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
    public partial class fBai1 : Form
    {
        public fBai1()
        {
            InitializeComponent();
        }

        private void fBai1_Load(object sender, EventArgs e)
        {
            HangHoa hangHoa = new HangHoa();
            hangHoa.maHang = "C1";
            hangHoa.tenHang = "Laptop";
            hangHoa.DVT = "cái";
            hangHoa.soLuong = 2;
            hangHoa.donGia = 17500000;

            label2.Text = hangHoa.HienThi();
        }

        
    }
}
