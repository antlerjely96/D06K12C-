namespace tinhTongHieuTichThuong
{
    partial class Form1
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
            this.soA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tongAB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hieuAB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tichAB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.thuongAB = new System.Windows.Forms.TextBox();
            this.tinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // soA
            // 
            this.soA.Location = new System.Drawing.Point(175, 12);
            this.soA.Name = "soA";
            this.soA.Size = new System.Drawing.Size(224, 38);
            this.soA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(53, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // soB
            // 
            this.soB.Location = new System.Drawing.Point(175, 72);
            this.soB.Name = "soB";
            this.soB.Size = new System.Drawing.Size(224, 38);
            this.soB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(53, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "a + b =";
            // 
            // tongAB
            // 
            this.tongAB.Enabled = false;
            this.tongAB.Location = new System.Drawing.Point(175, 136);
            this.tongAB.Name = "tongAB";
            this.tongAB.Size = new System.Drawing.Size(224, 38);
            this.tongAB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(53, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "a - b =";
            // 
            // hieuAB
            // 
            this.hieuAB.Enabled = false;
            this.hieuAB.Location = new System.Drawing.Point(175, 199);
            this.hieuAB.Name = "hieuAB";
            this.hieuAB.Size = new System.Drawing.Size(224, 38);
            this.hieuAB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(53, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "a * b =";
            // 
            // tichAB
            // 
            this.tichAB.Enabled = false;
            this.tichAB.Location = new System.Drawing.Point(175, 258);
            this.tichAB.Name = "tichAB";
            this.tichAB.Size = new System.Drawing.Size(224, 38);
            this.tichAB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(53, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "a / b =";
            // 
            // thuongAB
            // 
            this.thuongAB.Enabled = false;
            this.thuongAB.Location = new System.Drawing.Point(175, 320);
            this.thuongAB.Name = "thuongAB";
            this.thuongAB.Size = new System.Drawing.Size(224, 38);
            this.thuongAB.TabIndex = 11;
            // 
            // tinh
            // 
            this.tinh.Location = new System.Drawing.Point(175, 381);
            this.tinh.Name = "tinh";
            this.tinh.Size = new System.Drawing.Size(149, 57);
            this.tinh.TabIndex = 12;
            this.tinh.Text = "tinh";
            this.tinh.UseVisualStyleBackColor = true;
            this.tinh.Click += new System.EventHandler(this.tinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tinh);
            this.Controls.Add(this.thuongAB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tichAB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hieuAB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tongAB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tongAB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hieuAB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tichAB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox thuongAB;
        private System.Windows.Forms.Button tinh;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soB;
        private System.Windows.Forms.Label label3;

        #endregion
    }
}