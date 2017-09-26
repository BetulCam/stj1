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
    public partial class AkademisyenGiris : Form
    {
        public AkademisyenGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        private void AkademisyenGiris_Load(object sender, EventArgs e)
        {

        }

        private void girisA_Click(object sender, EventArgs e)
        {
            string ad = adA.Text;
            string soyad = sifreA.Text;
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM AcademicP where NameA='" + adA.Text + "' AND TcNoA='" + sifreA.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                AkadPersonelSecim apd = new AkadPersonelSecim();
                apd.Show();

            }
            else
                MessageBox.Show("Kullanıcı veya sifre yanlıs");
            conn.Close();
        }

    }
    }

