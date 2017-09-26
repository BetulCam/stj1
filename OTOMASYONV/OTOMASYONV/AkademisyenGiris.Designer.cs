namespace OTOMASYONV
{
    partial class AkademisyenGiris
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
            this.girisA = new System.Windows.Forms.Button();
            this.adA = new System.Windows.Forms.TextBox();
            this.sifreA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Akademisyen Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // girisA
            // 
            this.girisA.Location = new System.Drawing.Point(165, 190);
            this.girisA.Name = "girisA";
            this.girisA.Size = new System.Drawing.Size(75, 23);
            this.girisA.TabIndex = 2;
            this.girisA.Text = "Giris";
            this.girisA.UseVisualStyleBackColor = true;
            this.girisA.Click += new System.EventHandler(this.girisA_Click);
            // 
            // adA
            // 
            this.adA.Location = new System.Drawing.Point(127, 49);
            this.adA.Name = "adA";
            this.adA.Size = new System.Drawing.Size(100, 20);
            this.adA.TabIndex = 3;
            // 
            // sifreA
            // 
            this.sifreA.Location = new System.Drawing.Point(127, 103);
            this.sifreA.Name = "sifreA";
            this.sifreA.PasswordChar = '*';
            this.sifreA.Size = new System.Drawing.Size(100, 20);
            this.sifreA.TabIndex = 4;
            // 
            // AkademisyenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sifreA);
            this.Controls.Add(this.adA);
            this.Controls.Add(this.girisA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AkademisyenGiris";
            this.Text = "AkademisyenGiris";
            this.Load += new System.EventHandler(this.AkademisyenGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisA;
        private System.Windows.Forms.TextBox adA;
        private System.Windows.Forms.TextBox sifreA;
    }
}