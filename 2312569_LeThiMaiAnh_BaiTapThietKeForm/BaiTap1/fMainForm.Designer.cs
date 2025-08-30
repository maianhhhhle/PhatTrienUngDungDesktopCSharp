namespace BaiTap1
{
    partial class fFormChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiLeThiMaiAnh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBaiTap1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBaiTap2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBaiTap3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiTập4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLeThiMaiAnh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(878, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiLeThiMaiAnh
            // 
            this.tsmiLeThiMaiAnh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBaiTap1,
            this.tsmiBaiTap2,
            this.tsmiBaiTap3,
            this.bàiTập4ToolStripMenuItem});
            this.tsmiLeThiMaiAnh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLeThiMaiAnh.Name = "tsmiLeThiMaiAnh";
            this.tsmiLeThiMaiAnh.Size = new System.Drawing.Size(207, 37);
            this.tsmiLeThiMaiAnh.Text = "Lê Thị Mai Anh";
            // 
            // tsmiBaiTap1
            // 
            this.tsmiBaiTap1.Image = global::BaiTap1.Properties.Resources.iconbaitap1;
            this.tsmiBaiTap1.Name = "tsmiBaiTap1";
            this.tsmiBaiTap1.Size = new System.Drawing.Size(270, 42);
            this.tsmiBaiTap1.Text = "Bài tập 1";
            this.tsmiBaiTap1.Click += new System.EventHandler(this.tsmiBaiTap1_Click);
            // 
            // tsmiBaiTap2
            // 
            this.tsmiBaiTap2.Image = global::BaiTap1.Properties.Resources.iconbai2;
            this.tsmiBaiTap2.Name = "tsmiBaiTap2";
            this.tsmiBaiTap2.Size = new System.Drawing.Size(270, 42);
            this.tsmiBaiTap2.Text = "Bài tập 2";
            this.tsmiBaiTap2.Click += new System.EventHandler(this.tsmiBaiTap2_Click);
            // 
            // tsmiBaiTap3
            // 
            this.tsmiBaiTap3.Image = global::BaiTap1.Properties.Resources.icon3;
            this.tsmiBaiTap3.Name = "tsmiBaiTap3";
            this.tsmiBaiTap3.Size = new System.Drawing.Size(270, 42);
            this.tsmiBaiTap3.Text = "Bài tập 3";
            this.tsmiBaiTap3.Click += new System.EventHandler(this.tsmiBaiTap3_Click);
            // 
            // bàiTập4ToolStripMenuItem
            // 
            this.bàiTập4ToolStripMenuItem.Image = global::BaiTap1.Properties.Resources.anhxe2;
            this.bàiTập4ToolStripMenuItem.Name = "bàiTập4ToolStripMenuItem";
            this.bàiTập4ToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.bàiTập4ToolStripMenuItem.Text = "Bài tập 4";
            this.bàiTập4ToolStripMenuItem.Click += new System.EventHandler(this.bàiTập4ToolStripMenuItem_Click);
            // 
            // fFormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 427);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fFormChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập thiết kế form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLeThiMaiAnh;
        private System.Windows.Forms.ToolStripMenuItem tsmiBaiTap1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBaiTap2;
        private System.Windows.Forms.ToolStripMenuItem tsmiBaiTap3;
        private System.Windows.Forms.ToolStripMenuItem bàiTập4ToolStripMenuItem;
    }
}

