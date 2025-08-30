using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class fBai2 : Form
    {
        public fBai2()
        {
            InitializeComponent();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = lbDanhSachHangHoa.SelectedItem;
            lbCacMatHangKhachHangMua.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            var item = lbCacMatHangKhachHangMua.SelectedItem;
            lbCacMatHangKhachHangMua.Items.Remove(item);

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            foreach (string mathang in lbCacMatHangKhachHangMua.Items)
            {
                switch (mathang)
                {
                    case "Chuột":
                        tongTien += 100000;
                        break;

                    case "Máy in":
                        tongTien += 2000000;
                        break;

                    case "Bàn phím":
                        tongTien += 150000;
                        break;

                    case "USB Kingmax":
                        tongTien += 200000;
                        break;
                }
            }
            lblTongTien.Text = tongTien.ToString();
        }
    }
}
