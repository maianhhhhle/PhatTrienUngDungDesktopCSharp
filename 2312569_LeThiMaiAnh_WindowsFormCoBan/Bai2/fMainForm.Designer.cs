namespace Bai2
{
    partial class fMainForm
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
            this.grbChonGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.grbChonMau = new System.Windows.Forms.GroupBox();
            this.btnToMau = new System.Windows.Forms.Button();
            this.rdbMauVang = new System.Windows.Forms.RadioButton();
            this.rdbMauXanh = new System.Windows.Forms.RadioButton();
            this.rdbMauTim = new System.Windows.Forms.RadioButton();
            this.txtToMau = new System.Windows.Forms.TextBox();
            this.grbChonGioiTinh.SuspendLayout();
            this.grbChonMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChonGioiTinh
            // 
            this.grbChonGioiTinh.Controls.Add(this.rdbNu);
            this.grbChonGioiTinh.Controls.Add(this.rdbNam);
            this.grbChonGioiTinh.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChonGioiTinh.Location = new System.Drawing.Point(108, 49);
            this.grbChonGioiTinh.Name = "grbChonGioiTinh";
            this.grbChonGioiTinh.Size = new System.Drawing.Size(242, 190);
            this.grbChonGioiTinh.TabIndex = 0;
            this.grbChonGioiTinh.TabStop = false;
            this.grbChonGioiTinh.Text = "Chọn giới tính";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(80, 122);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(66, 29);
            this.rdbNu.TabIndex = 0;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.rdbNu_CheckedChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(80, 51);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(82, 29);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // grbChonMau
            // 
            this.grbChonMau.Controls.Add(this.btnToMau);
            this.grbChonMau.Controls.Add(this.rdbMauVang);
            this.grbChonMau.Controls.Add(this.rdbMauXanh);
            this.grbChonMau.Controls.Add(this.rdbMauTim);
            this.grbChonMau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChonMau.Location = new System.Drawing.Point(40, 292);
            this.grbChonMau.Name = "grbChonMau";
            this.grbChonMau.Size = new System.Drawing.Size(392, 230);
            this.grbChonMau.TabIndex = 1;
            this.grbChonMau.TabStop = false;
            this.grbChonMau.Text = "Chọn màu";
            // 
            // btnToMau
            // 
            this.btnToMau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMau.Location = new System.Drawing.Point(233, 106);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(122, 47);
            this.btnToMau.TabIndex = 1;
            this.btnToMau.Text = "Tô màu";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // rdbMauVang
            // 
            this.rdbMauVang.AutoSize = true;
            this.rdbMauVang.Location = new System.Drawing.Point(32, 164);
            this.rdbMauVang.Name = "rdbMauVang";
            this.rdbMauVang.Size = new System.Drawing.Size(139, 30);
            this.rdbMauVang.TabIndex = 0;
            this.rdbMauVang.TabStop = true;
            this.rdbMauVang.Text = "Màu vàng";
            this.rdbMauVang.UseVisualStyleBackColor = true;
            // 
            // rdbMauXanh
            // 
            this.rdbMauXanh.AutoSize = true;
            this.rdbMauXanh.Location = new System.Drawing.Point(32, 109);
            this.rdbMauXanh.Name = "rdbMauXanh";
            this.rdbMauXanh.Size = new System.Drawing.Size(141, 30);
            this.rdbMauXanh.TabIndex = 0;
            this.rdbMauXanh.TabStop = true;
            this.rdbMauXanh.Text = "Màu xanh";
            this.rdbMauXanh.UseVisualStyleBackColor = true;
            // 
            // rdbMauTim
            // 
            this.rdbMauTim.AutoSize = true;
            this.rdbMauTim.Location = new System.Drawing.Point(32, 58);
            this.rdbMauTim.Name = "rdbMauTim";
            this.rdbMauTim.Size = new System.Drawing.Size(125, 30);
            this.rdbMauTim.TabIndex = 0;
            this.rdbMauTim.TabStop = true;
            this.rdbMauTim.Text = "Màu tím";
            this.rdbMauTim.UseVisualStyleBackColor = true;
            // 
            // txtToMau
            // 
            this.txtToMau.Location = new System.Drawing.Point(490, 318);
            this.txtToMau.Multiline = true;
            this.txtToMau.Name = "txtToMau";
            this.txtToMau.Size = new System.Drawing.Size(231, 168);
            this.txtToMau.TabIndex = 2;
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 621);
            this.Controls.Add(this.txtToMau);
            this.Controls.Add(this.grbChonMau);
            this.Controls.Add(this.grbChonGioiTinh);
            this.Name = "fMainForm";
            this.Text = "Bài tập 2";
            this.grbChonGioiTinh.ResumeLayout(false);
            this.grbChonGioiTinh.PerformLayout();
            this.grbChonMau.ResumeLayout(false);
            this.grbChonMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChonGioiTinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.GroupBox grbChonMau;
        private System.Windows.Forms.RadioButton rdbMauVang;
        private System.Windows.Forms.RadioButton rdbMauXanh;
        private System.Windows.Forms.RadioButton rdbMauTim;
        private System.Windows.Forms.TextBox txtToMau;
        private System.Windows.Forms.Button btnToMau;
    }
}

