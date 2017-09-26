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
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;

        private void giris_Click(object sender, EventArgs e)
        {
            string ad = adO.Text;
            string soyad = sifreO.Text;
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM OgrBil where NameS='" + adO.Text + "' AND TcNoS='" + sifreO.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                OgrenciList oB = new OgrenciList();
                oB.Show();
                
            }
            else
                MessageBox.Show("Kullanıcı veya sifre yanlıs");
            conn.Close();
        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
