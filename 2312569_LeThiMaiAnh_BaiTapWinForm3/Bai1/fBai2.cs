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
    public partial class fBai2 : Form
    {
        public fBai2()
        {
            InitializeComponent();
        }

        private void rbChuyenKhoan_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cobTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cobTenHang.Text)
            {
                case "Chuột":
                    txtDonGia.Text = "100000";
                    break;

                case "Máy in":
                    txtDonGia.Text = "2000000";
                    break;
                case "Bàn phím":
                    txtDonGia.Text = "150000";
                    break;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            if (rbChuyenKhoan.Checked)
            {
                tongtien = (int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text)) * 95 / 100;
                lblTienThanhToan.Text = tongtien.ToString();
            }
            if (rbTienMat.Checked)
            {
                tongtien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
                lblTienThanhToan.Text = tongtien.ToString();

            }
        }
        }
}
