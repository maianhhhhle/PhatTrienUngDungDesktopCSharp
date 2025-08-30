namespace Bai1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem,
            this.bài2ToolStripMenuItem,
            this.bài3ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 42);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bài1ToolStripMenuItem.Image = global::Bai1.Properties.Resources.iconbai31;
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.bài1ToolStripMenuItem.Text = "Bài 1";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click_1);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bài2ToolStripMenuItem.Image = global::Bai1.Properties.Resources.iconbai21;
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            this.bài2ToolStripMenuItem.Click += new System.EventHandler(this.bài2ToolStripMenuItem_Click);
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bài3ToolStripMenuItem.Image = global::Bai1.Properties.Resources.iconbaitap1;
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "fMainForm";
            this.Text = "Chương trình chính";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem bài1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài3ToolStripMenuItem;
    }
}

