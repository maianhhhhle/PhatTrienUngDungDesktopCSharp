using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
                MessageBox.Show("Giới tính của bạn là nam", "Thông báo");
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNu.Checked)
                MessageBox.Show("Giới tính của bạn là nữ", "Thông báo");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdbMauTim.Checked)
                txtToMau.BackColor = Color.MediumPurple;
            else if(rdbMauXanh.Checked)
                txtToMau.BackColor = Color.GreenYellow;
            else txtToMau.BackColor = Color.Yellow;
        }

       
    }
}
