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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên của bạn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bạn đã nhập:";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(447, 65);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(410, 42);
            this.txtNhap.TabIndex = 2;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaoChep.Location = new System.Drawing.Point(447, 273);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.ReadOnly = true;
            this.txtSaoChep.Size = new System.Drawing.Size(410, 42);
            this.txtSaoChep.TabIndex = 2;
            // 
            // btnXuLy
            // 
            this.btnXuLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy.Location = new System.Drawing.Point(504, 186);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(99, 39);
            this.btnXuLy.TabIndex = 3;
            this.btnXuLy.Text = "Xử lý";
            this.btnXuLy.UseVisualStyleBackColor = true;
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoChep.Location = new System.Drawing.Point(684, 186);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(137, 39);
            this.btnSaoChep.TabIndex = 3;
            this.btnSaoChep.Text = "Sao chép";
            this.btnSaoChep.UseVisualStyleBackColor = true;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 474);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fMainForm";
            this.Text = "Bài tập 1";
            this.Load += new System.EventHandler(this.fMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Button btnSaoChep;
    }
}

