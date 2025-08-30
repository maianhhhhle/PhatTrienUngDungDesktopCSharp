namespace BaiTap1
{
    partial class fBai4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblNhapSoCanTim = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblHienThiKetQua = new System.Windows.Forms.Label();
            this.txtSoCanTim = new System.Windows.Forms.TextBox();
            this.btnTimSo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Items.AddRange(new object[] {
            "11",
            "9",
            "8",
            "76",
            "44",
            "36",
            "576",
            "98",
            "134",
            "65"});
            this.listBox1.Location = new System.Drawing.Point(26, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 364);
            this.listBox1.TabIndex = 0;
            // 
            // lblNhapSoCanTim
            // 
            this.lblNhapSoCanTim.AutoSize = true;
            this.lblNhapSoCanTim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapSoCanTim.Location = new System.Drawing.Point(290, 66);
            this.lblNhapSoCanTim.Name = "lblNhapSoCanTim";
            this.lblNhapSoCanTim.Size = new System.Drawing.Size(195, 30);
            this.lblNhapSoCanTim.TabIndex = 1;
            this.lblNhapSoCanTim.Text = "Nhập số cần tìm:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(312, 247);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(110, 31);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "Kết quả:";
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // lblHienThiKetQua
            // 
            this.lblHienThiKetQua.AutoSize = true;
            this.lblHienThiKetQua.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiKetQua.ForeColor = System.Drawing.Color.Red;
            this.lblHienThiKetQua.Location = new System.Drawing.Point(485, 247);
            this.lblHienThiKetQua.Name = "lblHienThiKetQua";
            this.lblHienThiKetQua.Size = new System.Drawing.Size(0, 31);
            this.lblHienThiKetQua.TabIndex = 1;
            // 
            // txtSoCanTim
            // 
            this.txtSoCanTim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCanTim.Location = new System.Drawing.Point(523, 58);
            this.txtSoCanTim.Name = "txtSoCanTim";
            this.txtSoCanTim.Size = new System.Drawing.Size(100, 38);
            this.txtSoCanTim.TabIndex = 2;
            // 
            // btnTimSo
            // 
            this.btnTimSo.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSo.Location = new System.Drawing.Point(401, 125);
            this.btnTimSo.Name = "btnTimSo";
            this.btnTimSo.Size = new System.Drawing.Size(137, 37);
            this.btnTimSo.TabIndex = 3;
            this.btnTimSo.Text = "Tìm số";
            this.btnTimSo.UseVisualStyleBackColor = true;
            this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
            // 
            // fBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 416);
            this.Controls.Add(this.btnTimSo);
            this.Controls.Add(this.txtSoCanTim);
            this.Controls.Add(this.lblHienThiKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblNhapSoCanTim);
            this.Controls.Add(this.listBox1);
            this.Name = "fBai4";
            this.Text = "Tìm số trong danh sách";
            this.Load += new System.EventHandler(this.fBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblNhapSoCanTim;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblHienThiKetQua;
        private System.Windows.Forms.TextBox txtSoCanTim;
        private System.Windows.Forms.Button btnTimSo;
    }
}