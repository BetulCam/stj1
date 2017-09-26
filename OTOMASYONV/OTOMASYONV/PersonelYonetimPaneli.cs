using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOMASYONV
{
    public partial class PersonelYonetimPaneli : Form
    {
        public PersonelYonetimPaneli()
        {
            InitializeComponent();
        }

        private void PersonelYonetimPaneli_Load(object sender, EventArgs e)
        {
            string[] tipler = { "Akademisyen", "Ogrenci", "Personel" +
                    "" };
            Ysecim.Items.AddRange(tipler);
        }

        private void yonet_Click(object sender, EventArgs e)
        {
            if (Ysecim.Text == "Akademisyen")
            {
                this.Hide();
                AkademikYönetim ay = new AkademikYönetim();
                ay.Show();
            }
            if (Ysecim.Text == "Ogrenci")
            {
                this.Hide();
                OgrenciYonetimi oy = new OgrenciYonetimi();
                oy.Show();
            }
            if (Ysecim.Text == "Personel")
            {
                this.Hide();
                PersonelYonetimi py = new PersonelYonetimi();
                py.Show();
            }
            
        }
    }
}
