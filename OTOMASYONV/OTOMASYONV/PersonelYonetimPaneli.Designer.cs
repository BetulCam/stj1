namespace OTOMASYONV
{
    partial class PersonelYonetimPaneli
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
            this.Ysecim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yonet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ysecim
            // 
            this.Ysecim.FormattingEnabled = true;
            this.Ysecim.Location = new System.Drawing.Point(74, 77);
            this.Ysecim.Name = "Ysecim";
            this.Ysecim.Size = new System.Drawing.Size(121, 21);
            this.Ysecim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetmek İstediğiniz Paneli Seciniz";
            // 
            // yonet
            // 
            this.yonet.Location = new System.Drawing.Point(105, 147);
            this.yonet.Name = "yonet";
            this.yonet.Size = new System.Drawing.Size(75, 23);
            this.yonet.TabIndex = 2;
            this.yonet.Text = "Giris";
            this.yonet.UseVisualStyleBackColor = true;
            this.yonet.Click += new System.EventHandler(this.yonet_Click);
            // 
            // PersonelYonetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.yonet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ysecim);
            this.Name = "PersonelYonetimPaneli";
            this.Text = "PersonelYonetimPaneli";
            this.Load += new System.EventHandler(this.PersonelYonetimPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Ysecim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yonet;
    }
}