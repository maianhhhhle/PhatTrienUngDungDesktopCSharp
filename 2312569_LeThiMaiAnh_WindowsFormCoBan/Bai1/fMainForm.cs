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
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
        }


        private void fMainForm_Load(object sender, EventArgs e)
        {
            txtNhap.Select();
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
           txtSaoChep.Text = txtNhap.Text;
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtNhap.Text;
        }
    }
}
