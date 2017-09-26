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
    public partial class AkadPersonelSecim : Form
    {
        public AkadPersonelSecim()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security=SSPI");
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        DataSet ds;
        DataTable tablo2 = new DataTable();
        DataTable tablo3 = new DataTable();

        string sql = "SELECT * FROM OgrBil";
        string sorgu;
        string secilen_id = "-1";

        void gridDoldur()
        {
            da = new SqlDataAdapter("SELECT * FROM OgrBil", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "OgrBil");
            dataGridView1.DataSource = ds.Tables["OgrBil"];
            conn.Close();
        }
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            
        }
        void derskoy()
        {
            da = new SqlDataAdapter("SELECT * FROM Lesson", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Lesson");
            dataGridView3.DataSource = ds.Tables["Lesson"];
            conn.Close();
        }

        void notListele()
        {
            da = new SqlDataAdapter("SELECT * FROM SinavBil", conn);
            ds = new DataSet();
            conn.Open();
            sorgu = "SELECT * FROM SinavBil where LessonID='"+secilen_id+"'";
            da.Fill(ds,"SinavBil");
            dataGridView2.DataSource = ds.Tables["SinavBil"];
            conn.Close();
            
        }


        private void AkadPersonelSecim_Load(object sender, EventArgs e)
        {
            gridDoldur();
            notListele();
            derskoy();
            
        }

        private void Butara_Click(object sender, EventArgs e)
        {
            if (FGore.Checked)
            {
                sql = "SELECT * FROM OgrBil WHERE PartsId='" + ara.Text + "'";
            }
            else if (SNGore.Checked)
            {
                sql = "SELECT * FROM OgrBil WHERE SchNo='" + ara.Text + "'";
            }
            else
                sql = "SELECT * FROM OgrBil";

            Listele(sql);
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            sql = "SELECT *FROM OgrBil";
            Listele(sql);
        }

        private void notEdit_Click(object sender, EventArgs e)
        {
            conn.Open();
            sorgu = "INSERT INTO SinavBil (arasinav,kisaSinav1,kisaSinav2,odev,final,LessonID,SchNo) VALUES(@as,@ks1,@ks2,@od,@fl,@pI,@sN)";

            cmd = new SqlCommand(sorgu,conn);
            cmd.Parameters.AddWithValue("@as",araS.Text);
            cmd.Parameters.AddWithValue("@ks1",Ksinav1.Text);
            cmd.Parameters.AddWithValue("@ks2",Ksinav2.Text);
            cmd.Parameters.AddWithValue("@od",Odev.Text);
            cmd.Parameters.AddWithValue("@fl",Final.Text);
            cmd.Parameters.AddWithValue("@pI",dataGridView3.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@sN",dataGridView1.CurrentRow.Cells[3].Value);
            cmd.ExecuteNonQuery();
            conn.Close();
            notListele();
            foreach (Control item in this.Controls)
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen_id = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            oNo.Text = dataGridView1.CurrentRow.Cells["SchNo"].Value.ToString();
            notListele();
        }

        private void FGore_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ara_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

