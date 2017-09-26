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
    public partial class DersYönetimPaneli : Form
    {
        public DersYönetimPaneli()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Server = PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security = SSPI");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        void gridGetir()
        {
            da = new SqlDataAdapter("SELECT * FROM DersBil",conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds,"DersBil");
            dataGridView1.DataSource = ds.Tables["DersBil"];
            conn.Close();
        }

        private void DersYönetimPaneli_Load(object sender, EventArgs e)
        {
            gridGetir();
        }

        private void ekleD_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText="insert into DersBil(DersAd,DersFakult,DersAka,DersDon)value("+tdersA+ ",'"+fakulteD+ "','"+akdmsyenD+ "','"+donemD+"')";
            cmd.ExecuteNonQuery();
            conn.Close();
            gridGetir();
        }

        private void silD_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "delete from DersBil where IdD =" +tdersK +"";
            cmd.ExecuteNonQuery();
            conn.Close();
            gridGetir();
        }

        private void editD_Click(object sender, EventArgs e)
        {
           

        }
    }
}
