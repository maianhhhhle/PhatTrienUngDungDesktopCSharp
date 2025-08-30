namespace Bai1
{
    partial class fBai2
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
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblTienThanhToan = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cobTenHang = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.grbThanhToan = new System.Windows.Forms.GroupBox();
            this.rbTienMat = new System.Windows.Forms.RadioButton();
            this.rbChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.grbThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.Location = new System.Drawing.Point(115, 22);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(119, 30);
            this.lblTenHang.TabIndex = 0;
            this.lblTenHang.Text = "Tên hàng:";
            // 
            // lblTienThanhToan
            // 
            this.lblTienThanhToan.AutoSize = true;
            this.lblTienThanhToan.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThanhToan.Location = new System.Drawing.Point(316, 471);
            this.lblTienThanhToan.Name = "lblTienThanhToan";
            this.lblTienThanhToan.Size = new System.Drawing.Size(0, 40);
            this.lblTienThanhToan.TabIndex = 0;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(115, 83);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(102, 30);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(115, 146);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(113, 30);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số tiền thanh toán:";
            // 
            // cobTenHang
            // 
            this.cobTenHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobTenHang.FormattingEnabled = true;
            this.cobTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.cobTenHang.Location = new System.Drawing.Point(266, 14);
            this.cobTenHang.Name = "cobTenHang";
            this.cobTenHang.Size = new System.Drawing.Size(186, 38);
            this.cobTenHang.TabIndex = 1;
            this.cobTenHang.SelectedIndexChanged += new System.EventHandler(this.cobTenHang_SelectedIndexChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(266, 83);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(186, 38);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(266, 146);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(186, 38);
            this.txtSoLuong.TabIndex = 2;
            // 
            // grbThanhToan
            // 
            this.grbThanhToan.Controls.Add(this.rbChuyenKhoan);
            this.grbThanhToan.Controls.Add(this.rbTienMat);
            this.grbThanhToan.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThanhToan.Location = new System.Drawing.Point(120, 217);
            this.grbThanhToan.Name = "grbThanhToan";
            this.grbThanhToan.Size = new System.Drawing.Size(290, 141);
            this.grbThanhToan.TabIndex = 3;
            this.grbThanhToan.TabStop = false;
            this.grbThanhToan.Text = "Hình thức thanh toán";
            // 
            // rbTienMat
            // 
            this.rbTienMat.AutoSize = true;
            this.rbTienMat.Location = new System.Drawing.Point(30, 44);
            this.rbTienMat.Name = "rbTienMat";
            this.rbTienMat.Size = new System.Drawing.Size(134, 34);
            this.rbTienMat.TabIndex = 0;
            this.rbTienMat.TabStop = true;
            this.rbTienMat.Text = "Tiền mặt";
            this.rbTienMat.UseVisualStyleBackColor = true;
            // 
            // rbChuyenKhoan
            // 
            this.rbChuyenKhoan.AutoSize = true;
            this.rbChuyenKhoan.Location = new System.Drawing.Point(30, 101);
            this.rbChuyenKhoan.Name = "rbChuyenKhoan";
            this.rbChuyenKhoan.Size = new System.Drawing.Size(195, 34);
            this.rbChuyenKhoan.TabIndex = 0;
            this.rbChuyenKhoan.TabStop = true;
            this.rbChuyenKhoan.Text = "Chuyển khoản";
            this.rbChuyenKhoan.UseVisualStyleBackColor = true;
            this.rbChuyenKhoan.CheckedChanged += new System.EventHandler(this.rbChuyenKhoan_CheckedChanged);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(206, 382);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(139, 49);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // fBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 532);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.grbThanhToan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cobTenHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTienThanhToan);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblTenHang);
            this.Name = "fBai2";
            this.Text = "Bài 2";
            this.grbThanhToan.ResumeLayout(false);
            this.grbThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblTienThanhToan;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cobTenHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox grbThanhToan;
        private System.Windows.Forms.RadioButton rbChuyenKhoan;
        private System.Windows.Forms.RadioButton rbTienMat;
        private System.Windows.Forms.Button btnTinhTien;
    }
}