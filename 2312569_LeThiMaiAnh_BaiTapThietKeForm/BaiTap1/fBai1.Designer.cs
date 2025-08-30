namespace BaiTap1
{
    partial class fBai1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picbXe = new System.Windows.Forms.PictureBox();
            this.grbChonMauXe = new System.Windows.Forms.GroupBox();
            this.rabTrang = new System.Windows.Forms.RadioButton();
            this.rabDo = new System.Windows.Forms.RadioButton();
            this.rabXanh = new System.Windows.Forms.RadioButton();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butTinhTien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTienThanhToan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbXe)).BeginInit();
            this.grbChonMauXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbXe
            // 
            this.picbXe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picbXe.BackgroundImage = global::BaiTap1.Properties.Resources.anhxe1;
            this.picbXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbXe.Location = new System.Drawing.Point(12, 67);
            this.picbXe.Name = "picbXe";
            this.picbXe.Size = new System.Drawing.Size(548, 339);
            this.picbXe.TabIndex = 0;
            this.picbXe.TabStop = false;
            // 
            // grbChonMauXe
            // 
            this.grbChonMauXe.Controls.Add(this.rabTrang);
            this.grbChonMauXe.Controls.Add(this.rabDo);
            this.grbChonMauXe.Controls.Add(this.rabXanh);
            this.grbChonMauXe.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChonMauXe.Location = new System.Drawing.Point(704, 67);
            this.grbChonMauXe.Name = "grbChonMauXe";
            this.grbChonMauXe.Size = new System.Drawing.Size(337, 218);
            this.grbChonMauXe.TabIndex = 1;
            this.grbChonMauXe.TabStop = false;
            this.grbChonMauXe.Text = "Chọn màu xe";
            // 
            // rabTrang
            // 
            this.rabTrang.AutoSize = true;
            this.rabTrang.Location = new System.Drawing.Point(70, 161);
            this.rabTrang.Name = "rabTrang";
            this.rabTrang.Size = new System.Drawing.Size(103, 37);
            this.rabTrang.TabIndex = 0;
            this.rabTrang.Text = "Trắng";
            this.rabTrang.UseVisualStyleBackColor = true;
            this.rabTrang.CheckedChanged += new System.EventHandler(this.rabTrang_CheckedChanged);
            // 
            // rabDo
            // 
            this.rabDo.AutoSize = true;
            this.rabDo.Checked = true;
            this.rabDo.Location = new System.Drawing.Point(69, 108);
            this.rabDo.Name = "rabDo";
            this.rabDo.Size = new System.Drawing.Size(74, 37);
            this.rabDo.TabIndex = 0;
            this.rabDo.TabStop = true;
            this.rabDo.Text = "Đỏ";
            this.rabDo.UseVisualStyleBackColor = true;
            this.rabDo.CheckedChanged += new System.EventHandler(this.rabDo_CheckedChanged);
            // 
            // rabXanh
            // 
            this.rabXanh.AutoSize = true;
            this.rabXanh.Location = new System.Drawing.Point(69, 54);
            this.rabXanh.Name = "rabXanh";
            this.rabXanh.Size = new System.Drawing.Size(100, 37);
            this.rabXanh.TabIndex = 0;
            this.rabXanh.Text = "Xanh";
            this.rabXanh.UseVisualStyleBackColor = true;
            this.rabXanh.CheckedChanged += new System.EventHandler(this.rabXanh_CheckedChanged);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(651, 304);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(118, 32);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(651, 393);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(131, 32);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền thanh toán:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(814, 304);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(227, 40);
            this.txtDonGia.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(814, 385);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(227, 40);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1047, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "$";
            // 
            // butTinhTien
            // 
            this.butTinhTien.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTinhTien.Location = new System.Drawing.Point(856, 456);
            this.butTinhTien.Name = "butTinhTien";
            this.butTinhTien.Size = new System.Drawing.Size(141, 41);
            this.butTinhTien.TabIndex = 5;
            this.butTinhTien.Text = "Tính tiền";
            this.butTinhTien.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(856, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tính tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTienThanhToan
            // 
            this.lblTienThanhToan.AutoSize = true;
            this.lblTienThanhToan.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThanhToan.Location = new System.Drawing.Point(847, 539);
            this.lblTienThanhToan.Name = "lblTienThanhToan";
            this.lblTienThanhToan.Size = new System.Drawing.Size(0, 46);
            this.lblTienThanhToan.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1020, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 46);
            this.label4.TabIndex = 2;
            this.label4.Text = "$";
            // 
            // fBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butTinhTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTienThanhToan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.grbChonMauXe);
            this.Controls.Add(this.picbXe);
            this.Name = "fBai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mua bán xe";
            ((System.ComponentModel.ISupportInitialize)(this.picbXe)).EndInit();
            this.grbChonMauXe.ResumeLayout(false);
            this.grbChonMauXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbXe;
        private System.Windows.Forms.GroupBox grbChonMauXe;
        private System.Windows.Forms.RadioButton rabTrang;
        private System.Windows.Forms.RadioButton rabDo;
        private System.Windows.Forms.RadioButton rabXanh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butTinhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTienThanhToan;
        private System.Windows.Forms.Label label4;
    }
}