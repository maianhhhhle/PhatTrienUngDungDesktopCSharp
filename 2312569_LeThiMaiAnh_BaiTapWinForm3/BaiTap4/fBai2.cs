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
    public partial class fBai2 : Form
    {
        public fBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            double diemLT = double.Parse(txtDiemLyThuyet.Text);
            double diemTH = double.Parse(txtDiemThucHanh.Text);
            XepLoai(diemLT,diemTH);
        }

        private void txtDiemLyThuyet_TextChanged(object sender, EventArgs e)
        {
            KiemTraDiem(txtDiemLyThuyet);
            
        }

        private void txtDiemThucHanh_TextChanged(object sender, EventArgs e)
        {
            KiemTraDiem(txtDiemThucHanh);
        }
            
        private bool KiemTraDiem(TextBox txt)
        {
            double diem;
            if(!double.TryParse(txt.Text,out diem))
            {
                if (txt.Text != "")
                {
                    MessageBox.Show("Vui lòng nhập số!!", "Lỗi");
                    txt.Clear();
                }
                return false;
            }

            if(diem <0 || diem > 10)
            {
                MessageBox.Show("Điểm không hợp lê!!!", "Lỗi");
                txt.Clear();
                return false;
            }
            return true;
        }

        private void XepLoai(double diemLT, double diemTH)
        {
            double[] diem = { diemLT, diemTH };
            double diemTB = diem.Average();

            if (diemLT >= 5 && diemTH >= 5)
            {
                if (diemTB >= 9) lblKetQua.Text = "Xuất sắc";
                if (diemTB >= 8) lblKetQua.Text = "Giỏi";
                if (diemTB >= 7) lblKetQua.Text = "Khá";
                else lblKetQua.Text = "Trung bình";
            }
            else lblKetQua.Text = "Yếu";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDiemLyThuyet.Text = "";
            txtDiemThucHanh.Text = "";
            lblKetQua.Text = "";
        }
    }
}
