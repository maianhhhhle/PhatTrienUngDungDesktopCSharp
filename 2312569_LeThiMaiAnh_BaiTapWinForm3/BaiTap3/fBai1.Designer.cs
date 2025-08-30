namespace BaiTap3
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
            this.lblHienThiThongTin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHienThiThongTin
            // 
            this.lblHienThiThongTin.AutoSize = true;
            this.lblHienThiThongTin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiThongTin.Location = new System.Drawing.Point(266, 103);
            this.lblHienThiThongTin.Name = "lblHienThiThongTin";
            this.lblHienThiThongTin.Size = new System.Drawing.Size(77, 30);
            this.lblHienThiThongTin.TabIndex = 1;
            this.lblHienThiThongTin.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // fBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 242);
            this.Controls.Add(this.lblHienThiThongTin);
            this.Controls.Add(this.label1);
            this.Name = "fBai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.fBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThiThongTin;
        private System.Windows.Forms.Label label1;
    }
}