namespace OTOMASYONV
{
    partial class PersonelGiris
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
            this.adP = new System.Windows.Forms.TextBox();
            this.sifreP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adP
            // 
            this.adP.Location = new System.Drawing.Point(133, 63);
            this.adP.Name = "adP";
            this.adP.Size = new System.Drawing.Size(100, 20);
            this.adP.TabIndex = 0;
            // 
            // sifreP
            // 
            this.sifreP.Location = new System.Drawing.Point(133, 119);
            this.sifreP.Name = "sifreP";
            this.sifreP.PasswordChar = '*';
            this.sifreP.Size = new System.Drawing.Size(100, 20);
            this.sifreP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Sifresi";
            // 
            // girisP
            // 
            this.girisP.Location = new System.Drawing.Point(147, 189);
            this.girisP.Name = "girisP";
            this.girisP.Size = new System.Drawing.Size(75, 23);
            this.girisP.TabIndex = 5;
            this.girisP.Text = "Giris";
            this.girisP.UseVisualStyleBackColor = true;
            this.girisP.Click += new System.EventHandler(this.girisP_Click);
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.girisP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreP);
            this.Controls.Add(this.adP);
            this.Name = "PersonelGiris";
            this.Text = "PersonelGiris";
            this.Load += new System.EventHandler(this.PersonelGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adP;
        private System.Windows.Forms.TextBox sifreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisP;
    }
}