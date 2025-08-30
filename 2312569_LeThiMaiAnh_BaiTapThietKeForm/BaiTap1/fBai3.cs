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
    public partial class fBai3 : Form
    {
        List<string> list = new List<string>();

        public fBai3()
        {
            InitializeComponent();
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            string tu = txtTuMoi.Text;
            lbDanhSachTuMoi.Items.Add(tu);
            list.Add(txtNghiaCuaTu.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTuMoi.Text = "";
            txtNghiaCuaTu.Text = "";
        }

        private void fBai3_Load(object sender, EventArgs e)
        {
            txtTuMoi.Select();
        }

        private void lbDanhSachTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = lbDanhSachTuMoi.SelectedIndex;
            txtNghiaTu.Text = list[stt];
        }

        private void txtNghiaTu_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNghiaCuaTuMoi_Click(object sender, EventArgs e)
        {

        }

        private void lblDanhSachTuMoi_Click(object sender, EventArgs e)
        {

        }
    }
}
