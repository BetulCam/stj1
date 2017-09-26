namespace OTOMASYONV
{
    partial class AkademikYönetim
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
            this.ekleA = new System.Windows.Forms.Button();
            this.silA = new System.Windows.Forms.Button();
            this.duzenleA = new System.Windows.Forms.Button();
            this.cadA = new System.Windows.Forms.TextBox();
            this.csadA = new System.Windows.Forms.TextBox();
            this.adA = new System.Windows.Forms.Label();
            this.soyadA = new System.Windows.Forms.Label();
            this.fakulteA = new System.Windows.Forms.Label();
            this.cfakA = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tcnoA = new System.Windows.Forms.TextBox();
            this.mailA = new System.Windows.Forms.Label();
            this.derslerA = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.unvanA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ekleA
            // 
            this.ekleA.Location = new System.Drawing.Point(108, 262);
            this.ekleA.Name = "ekleA";
            this.ekleA.Size = new System.Drawing.Size(75, 23);
            this.ekleA.TabIndex = 0;
            this.ekleA.Text = "Ekle";
            this.ekleA.UseVisualStyleBackColor = true;
            this.ekleA.Click += new System.EventHandler(this.ekleA_Click);
            // 
            // silA
            // 
            this.silA.Location = new System.Drawing.Point(240, 262);
            this.silA.Name = "silA";
            this.silA.Size = new System.Drawing.Size(75, 23);
            this.silA.TabIndex = 1;
            this.silA.Text = "Sil";
            this.silA.UseVisualStyleBackColor = true;
            this.silA.Click += new System.EventHandler(this.silA_Click);
            // 
            // duzenleA
            // 
            this.duzenleA.Location = new System.Drawing.Point(358, 262);
            this.duzenleA.Name = "duzenleA";
            this.duzenleA.Size = new System.Drawing.Size(75, 23);
            this.duzenleA.TabIndex = 2;
            this.duzenleA.Text = "Düzenle";
            this.duzenleA.UseVisualStyleBackColor = true;
            this.duzenleA.Click += new System.EventHandler(this.duzenleA_Click);
            // 
            // cadA
            // 
            this.cadA.Location = new System.Drawing.Point(180, 44);
            this.cadA.Name = "cadA";
            this.cadA.Size = new System.Drawing.Size(100, 20);
            this.cadA.TabIndex = 3;
            // 
            // csadA
            // 
            this.csadA.Location = new System.Drawing.Point(180, 70);
            this.csadA.Name = "csadA";
            this.csadA.Size = new System.Drawing.Size(100, 20);
            this.csadA.TabIndex = 4;
            // 
            // adA
            // 
            this.adA.AutoSize = true;
            this.adA.Location = new System.Drawing.Point(94, 51);
            this.adA.Name = "adA";
            this.adA.Size = new System.Drawing.Size(20, 13);
            this.adA.TabIndex = 8;
            this.adA.Text = "Ad";
            // 
            // soyadA
            // 
            this.soyadA.AutoSize = true;
            this.soyadA.Location = new System.Drawing.Point(94, 77);
            this.soyadA.Name = "soyadA";
            this.soyadA.Size = new System.Drawing.Size(37, 13);
            this.soyadA.TabIndex = 9;
            this.soyadA.Text = "Soyad";
            // 
            // fakulteA
            // 
            this.fakulteA.AutoSize = true;
            this.fakulteA.Location = new System.Drawing.Point(94, 104);
            this.fakulteA.Name = "fakulteA";
            this.fakulteA.Size = new System.Drawing.Size(42, 13);
            this.fakulteA.TabIndex = 11;
            this.fakulteA.Text = "Fakulte";
            // 
            // cfakA
            // 
            this.cfakA.FormattingEnabled = true;
            this.cfakA.Location = new System.Drawing.Point(180, 96);
            this.cfakA.Name = "cfakA";
            this.cfakA.Size = new System.Drawing.Size(121, 21);
            this.cfakA.TabIndex = 13;
            this.cfakA.SelectedIndexChanged += new System.EventHandler(this.cfakA_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(353, 209);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "TcNo";
            // 
            // tcnoA
            // 
            this.tcnoA.Location = new System.Drawing.Point(180, 18);
            this.tcnoA.Name = "tcnoA";
            this.tcnoA.Size = new System.Drawing.Size(100, 20);
            this.tcnoA.TabIndex = 17;
            // 
            // mailA
            // 
            this.mailA.AutoSize = true;
            this.mailA.Location = new System.Drawing.Point(96, 158);
            this.mailA.Name = "mailA";
            this.mailA.Size = new System.Drawing.Size(26, 13);
            this.mailA.TabIndex = 18;
            this.mailA.Text = "Mail";
            // 
            // derslerA
            // 
            this.derslerA.AutoSize = true;
            this.derslerA.Location = new System.Drawing.Point(96, 196);
            this.derslerA.Name = "derslerA";
            this.derslerA.Size = new System.Drawing.Size(42, 13);
            this.derslerA.TabIndex = 19;
            this.derslerA.Text = "Dersleri";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // unvanA
            // 
            this.unvanA.AutoSize = true;
            this.unvanA.Location = new System.Drawing.Point(94, 126);
            this.unvanA.Name = "unvanA";
            this.unvanA.Size = new System.Drawing.Size(39, 13);
            this.unvanA.TabIndex = 22;
            this.unvanA.Text = "Unvan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // AkademikYönetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 318);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.unvanA);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.derslerA);
            this.Controls.Add(this.mailA);
            this.Controls.Add(this.tcnoA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cfakA);
            this.Controls.Add(this.fakulteA);
            this.Controls.Add(this.soyadA);
            this.Controls.Add(this.adA);
            this.Controls.Add(this.csadA);
            this.Controls.Add(this.cadA);
            this.Controls.Add(this.duzenleA);
            this.Controls.Add(this.silA);
            this.Controls.Add(this.ekleA);
            this.Name = "AkademikYönetim";
            this.Text = "AkademikYönetim";
            this.Load += new System.EventHandler(this.AkademikYönetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekleA;
        private System.Windows.Forms.Button silA;
        private System.Windows.Forms.Button duzenleA;
        private System.Windows.Forms.TextBox cadA;
        private System.Windows.Forms.TextBox csadA;
        private System.Windows.Forms.Label adA;
        private System.Windows.Forms.Label soyadA;
        private System.Windows.Forms.Label fakulteA;
        private System.Windows.Forms.ComboBox cfakA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcnoA;
        private System.Windows.Forms.Label mailA;
        private System.Windows.Forms.Label derslerA;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label unvanA;
        private System.Windows.Forms.TextBox textBox1;
    }
}