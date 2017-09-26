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
    public partial class AnaSecim : Form
    {
        public AnaSecim()
        {
            InitializeComponent();
        }

        private void AnaSecim_Load(object sender, EventArgs e)
        {
            string[] tipler = { "Akademisyen", "Ogrenci", "Personel" };
            KullTip.Items.AddRange(tipler);

            
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if (KullTip.Text == "Akademisyen")
            {
                this.Hide();
                AkademisyenGiris ag = new AkademisyenGiris();
                ag.Show();
            }
            if(KullTip.Text=="Ogrenci")
            {
                this.Hide();
                OgrenciGiris og = new OgrenciGiris();
                og.Show();
            }
            if(KullTip.Text=="Personel")
            {
                this.Hide();
                PersonelGiris pg = new PersonelGiris();
                pg.Show();
            }

        }

        private void KullTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
