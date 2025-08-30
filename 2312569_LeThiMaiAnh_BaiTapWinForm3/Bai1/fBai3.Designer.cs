namespace Bai1
{
    partial class fBai3
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
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhSoTong1n = new System.Windows.Forms.RadioButton();
            this.rdTinhSoTongAB = new System.Windows.Forms.RadioButton();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(322, 509);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(34, 40);
            this.lblKetQua.TabIndex = 19;
            this.lblKetQua.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 509);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kết quả là: ";
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKQ.Location = new System.Drawing.Point(165, 406);
            this.btnXemKQ.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(180, 74);
            this.btnXemKQ.TabIndex = 17;
            this.btnXemKQ.Text = "Xem Kết Quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhSoTong1n);
            this.groupBox1.Controls.Add(this.rdTinhSoTongAB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(111, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(280, 158);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdTinhSoTong1n
            // 
            this.rdTinhSoTong1n.AutoSize = true;
            this.rdTinhSoTong1n.Location = new System.Drawing.Point(32, 85);
            this.rdTinhSoTong1n.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdTinhSoTong1n.Name = "rdTinhSoTong1n";
            this.rdTinhSoTong1n.Size = new System.Drawing.Size(247, 34);
            this.rdTinhSoTong1n.TabIndex = 1;
            this.rdTinhSoTong1n.TabStop = true;
            this.rdTinhSoTong1n.Text = "Tính số tổng 1 -> n";
            this.rdTinhSoTong1n.UseVisualStyleBackColor = true;
            // 
            // rdTinhSoTongAB
            // 
            this.rdTinhSoTongAB.AutoSize = true;
            this.rdTinhSoTongAB.Location = new System.Drawing.Point(32, 39);
            this.rdTinhSoTongAB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdTinhSoTongAB.Name = "rdTinhSoTongAB";
            this.rdTinhSoTongAB.Size = new System.Drawing.Size(218, 34);
            this.rdTinhSoTongAB.TabIndex = 0;
            this.rdTinhSoTongAB.TabStop = true;
            this.rdTinhSoTongAB.Text = "Tính số tổng a, b";
            this.rdTinhSoTongAB.UseVisualStyleBackColor = true;
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(269, 152);
            this.txtSoN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(121, 38);
            this.txtSoN.TabIndex = 15;
            this.txtSoN.Text = "0";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(269, 86);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(121, 38);
            this.txtSoB.TabIndex = 14;
            this.txtSoB.Text = "0";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(269, 24);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(121, 38);
            this.txtSoA.TabIndex = 13;
            this.txtSoA.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số b = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số n = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số a = ";
            // 
            // fBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 563);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fBai3";
            this.Text = "Câu 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhSoTong1n;
        private System.Windows.Forms.RadioButton rdTinhSoTongAB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}