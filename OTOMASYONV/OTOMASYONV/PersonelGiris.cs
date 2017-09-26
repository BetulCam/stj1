using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OTOMASYONV
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection(@"Server=PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;

        private void PersonelGiris_Load(object sender, EventArgs e)
        {

        }

        private void girisP_Click(object sender, EventArgs e)
        {
            string ad = adP.Text;
            string soyad = sifreP.Text;
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Officer where NameO='" + adP.Text + "' AND TcNoO='" + sifreP.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //this.Hide();
                PersonelYonetimPaneli pyp = new PersonelYonetimPaneli();
                pyp.Show();
            }
            else
                MessageBox.Show("Kullanıcı veya sifre yanlıs");
            conn.Close();
        }
        
    }
}
