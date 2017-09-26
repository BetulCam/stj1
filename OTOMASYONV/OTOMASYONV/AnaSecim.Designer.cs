namespace OTOMASYONV
{
    partial class AnaSecim
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
            this.LoginL = new System.Windows.Forms.Label();
            this.KullTip = new System.Windows.Forms.ComboBox();
            this.giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginL
            // 
            this.LoginL.Location = new System.Drawing.Point(0, 0);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(100, 23);
            this.LoginL.TabIndex = 3;
            // 
            // KullTip
            // 
            this.KullTip.FormattingEnabled = true;
            this.KullTip.Location = new System.Drawing.Point(112, 83);
            this.KullTip.Name = "KullTip";
            this.KullTip.Size = new System.Drawing.Size(121, 21);
            this.KullTip.TabIndex = 1;
            this.KullTip.SelectedIndexChanged += new System.EventHandler(this.KullTip_SelectedIndexChanged);
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(134, 154);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(75, 23);
            this.giris.TabIndex = 2;
            this.giris.Text = "Giris";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giriş Kategorinizi Seciniz";
            // 
            // AnaSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.KullTip);
            this.Controls.Add(this.LoginL);
            this.Name = "AnaSecim";
            this.Text = "AnaSecim";
            this.Load += new System.EventHandler(this.AnaSecim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginL;
        private System.Windows.Forms.ComboBox KullTip;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Label label1;
    }
}

