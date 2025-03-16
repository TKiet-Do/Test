namespace Kiet_265
{
    partial class frmcaculate
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
            this.lbTong = new System.Windows.Forms.Label();
            this.lbHieu = new System.Windows.Forms.Label();
            this.lbTich = new System.Windows.Forms.Label();
            this.lbThuong = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtDiff = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtQuotient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập B:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(51, 117);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(56, 16);
            this.lbTong.TabIndex = 0;
            this.lbTong.Text = "Tổng là:";
            this.lbTong.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbHieu
            // 
            this.lbHieu.AutoSize = true;
            this.lbHieu.Location = new System.Drawing.Point(51, 158);
            this.lbHieu.Name = "lbHieu";
            this.lbHieu.Size = new System.Drawing.Size(52, 16);
            this.lbHieu.TabIndex = 0;
            this.lbHieu.Text = "Hiệu là:";
            // 
            // lbTich
            // 
            this.lbTich.AutoSize = true;
            this.lbTich.Location = new System.Drawing.Point(51, 202);
            this.lbTich.Name = "lbTich";
            this.lbTich.Size = new System.Drawing.Size(50, 16);
            this.lbTich.TabIndex = 0;
            this.lbTich.Text = "Tích là:";
            this.lbTich.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbThuong
            // 
            this.lbThuong.AutoSize = true;
            this.lbThuong.Location = new System.Drawing.Point(51, 244);
            this.lbThuong.Name = "lbThuong";
            this.lbThuong.Size = new System.Drawing.Size(70, 16);
            this.lbThuong.TabIndex = 0;
            this.lbThuong.Text = "Thương là:";
            this.lbThuong.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(96, 337);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(145, 65);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Tính";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(312, 337);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(145, 65);
            this.btnAgain.TabIndex = 2;
            this.btnAgain.Text = "Làm lại";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(536, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 65);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(270, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(357, 22);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(270, 69);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(357, 22);
            this.txtB.TabIndex = 3;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(270, 111);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(357, 22);
            this.txtSum.TabIndex = 3;
            // 
            // txtDiff
            // 
            this.txtDiff.Location = new System.Drawing.Point(270, 152);
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(357, 22);
            this.txtDiff.TabIndex = 3;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(270, 196);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(357, 22);
            this.txtProduct.TabIndex = 3;
            // 
            // txtQuotient
            // 
            this.txtQuotient.Location = new System.Drawing.Point(270, 238);
            this.txtQuotient.Name = "txtQuotient";
            this.txtQuotient.Size = new System.Drawing.Size(357, 22);
            this.txtQuotient.TabIndex = 3;
            // 
            // frmcaculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.txtQuotient);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtDiff);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lbThuong);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.lbTich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHieu);
            this.Controls.Add(this.label1);
            this.Name = "frmcaculate";
            this.Text = "frmcaculate";
            this.Load += new System.EventHandler(this.frmcaculate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbHieu;
        private System.Windows.Forms.Label lbTich;
        private System.Windows.Forms.Label lbThuong;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtDiff;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtQuotient;
    }
}