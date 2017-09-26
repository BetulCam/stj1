namespace OTOMASYONV
{
    partial class OgrenciGiris
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
            this.giris = new System.Windows.Forms.Button();
            this.zırt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adO = new System.Windows.Forms.TextBox();
            this.sifreO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(137, 181);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(75, 23);
            this.giris.TabIndex = 0;
            this.giris.Text = "button1";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // zırt
            // 
            this.zırt.AutoSize = true;
            this.zırt.Location = new System.Drawing.Point(41, 38);
            this.zırt.Name = "zırt";
            this.zırt.Size = new System.Drawing.Size(62, 13);
            this.zırt.TabIndex = 1;
            this.zırt.Text = "Ogrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OgrenciSifresi";
            // 
            // adO
            // 
            this.adO.Location = new System.Drawing.Point(119, 35);
            this.adO.Name = "adO";
            this.adO.Size = new System.Drawing.Size(100, 20);
            this.adO.TabIndex = 3;
            // 
            // sifreO
            // 
            this.sifreO.Location = new System.Drawing.Point(119, 80);
            this.sifreO.Name = "sifreO";
            this.sifreO.PasswordChar = '*';
            this.sifreO.Size = new System.Drawing.Size(100, 20);
            this.sifreO.TabIndex = 4;
            // 
            // OgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sifreO);
            this.Controls.Add(this.adO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zırt);
            this.Controls.Add(this.giris);
            this.Name = "OgrenciGiris";
            this.Text = "OgrenciGiris";
            this.Load += new System.EventHandler(this.OgrenciGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Label zırt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adO;
        private System.Windows.Forms.TextBox sifreO;
    }
}