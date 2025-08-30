namespace BaiTap4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtDiemLyThuyet = new System.Windows.Forms.TextBox();
            this.txtDiemThucHanh = new System.Windows.Forms.TextBox();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm lý thuyết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập điểm thực hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả xếp loại";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(467, 348);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(94, 35);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "label2";
            // 
            // txtDiemLyThuyet
            // 
            this.txtDiemLyThuyet.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemLyThuyet.Location = new System.Drawing.Point(463, 50);
            this.txtDiemLyThuyet.Name = "txtDiemLyThuyet";
            this.txtDiemLyThuyet.Size = new System.Drawing.Size(117, 38);
            this.txtDiemLyThuyet.TabIndex = 2;
            this.txtDiemLyThuyet.TextChanged += new System.EventHandler(this.txtDiemLyThuyet_TextChanged);
            // 
            // txtDiemThucHanh
            // 
            this.txtDiemThucHanh.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThucHanh.Location = new System.Drawing.Point(463, 123);
            this.txtDiemThucHanh.Name = "txtDiemThucHanh";
            this.txtDiemThucHanh.Size = new System.Drawing.Size(117, 38);
            this.txtDiemThucHanh.TabIndex = 2;
            this.txtDiemThucHanh.TextChanged += new System.EventHandler(this.txtDiemThucHanh_TextChanged);
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLoai.Location = new System.Drawing.Point(327, 207);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(139, 50);
            this.btnXepLoai.TabIndex = 3;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(526, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 50);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.txtDiemThucHanh);
            this.Controls.Add(this.txtDiemLyThuyet);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "fBai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xếp loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtDiemLyThuyet;
        private System.Windows.Forms.TextBox txtDiemThucHanh;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Button btnXoa;
    }
}