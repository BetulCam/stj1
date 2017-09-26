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
    public partial class OgrenciYonetimi : Form
    {
        public OgrenciYonetimi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security=SSPI");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        
        void gridDoldur()
        {
            da = new SqlDataAdapter("SELECT * FROM OgrBil",conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds,"OgrBil");
            dataGridView1.DataSource = ds.Tables["OgrBil"];
            conn.Close();
        }

        private void OgrenciYonetimi_Load(object sender, EventArgs e)
        {
            gridDoldur();
            conn = new SqlConnection(@"Server=PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security=SSPI");
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from FacultyS1 ORDER BY FacultyID ASC ", conn);
            da.Fill(dt);
            oFakulte.ValueMember = "FacultyID";
            oFakulte.DisplayMember = "CategoryName";
            oFakulte.DataSource = dt;
        }

        private void EkleO_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into OgrBil(TcNoS,NameS,LNameS,SchNo,PartsId,MailAdS,ParentID,OfficerId) values ( " + ttcnoO.Text +",'"+tadO.Text+ "','"+tsoyO.Text+ "','"+tnoO.Text+"','"+oBolum.SelectedValue+ "','"+tmailO.Text+ "','"+1 + "','"+1+"')";
            cmd.ExecuteNonQuery();
            conn.Close();
            gridDoldur();

            foreach(Control item in this.Controls)
                if(item is TextBox)

                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
           
        }

        private void SilO_Click(object sender, EventArgs e)
        {
            var asd = dataGridView1.SelectedRows[0];

            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "delete from OgrBil where TcNoS='"+asd.Cells["TcNoS"].Value + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            gridDoldur();
        }

        private void DuzenleO_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update OgrBil set NameS='"+tadO.Text+"',LNameS='"+tsoyO.Text+"',SchNo='"+tnoO.Text+"'where TcNoS='"+ttcnoO.Text+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            gridDoldur();

            foreach (Control item in this.Controls)
                if (item is TextBox)

                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }

        }

        private void oBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            }

        private void oFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oFakulte.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Parts where FacultyID =" + oFakulte.SelectedValue, conn);
                da.Fill(dt);
                oBolum.ValueMember = "PartsId";
                oBolum.DisplayMember = "PartsCat";
                oBolum.DataSource = dt;
            }
        }
    }

        
    }
