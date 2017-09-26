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
    public partial class AkademikYönetim : Form
    {
        public AkademikYönetim()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection(@"Server=PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        
        void gridDoldur()
        {
            da = new SqlDataAdapter("select * from AcademicP",conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds,"AcademicP");
            dataGridView1.DataSource = ds.Tables["AcademicP"];
            conn.Close();
        }

        private void AkademikYönetim_Load(object sender, EventArgs e)
        {
            gridDoldur();
            conn = new SqlConnection(@"Server=PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security=SSPI");
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from FacultyS1 ORDER BY FacultyID ASC ", conn);
            da.Fill(dt);
            cfakA.ValueMember = "FacultyID";
            cfakA.DisplayMember = "CategoryName";
            cfakA.DataSource = dt;
        }

        private void ekleA_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into AcademicP (TcNoA,NameA,LNameA,FacultyID,MStatusA,MailAdA,EduInfA, OfficerId) values ("+tcnoA.Text+ ",'" + cadA.Text+ "','"+csadA.Text+ "','"+cfakA.SelectedValue +"','"+textBox1.Text+ "','"+textBox3.Text+ "','" + comboBox1.SelectedValue+ "','" +1+ "')";
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

        private void silA_Click(object sender, EventArgs e)
        {
            var asd = dataGridView1.SelectedRows[0];

            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "delete from AcademicP where TcNoA = '"+asd.Cells["TcNoA"].Value +"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            gridDoldur();

        }

        private void duzenleA_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update AcademicP set NameA='" + cadA.Text + "',LNameA='" + csadA.Text + "',EduInfA='" + textBox1.Text + "',MailAdA='" + textBox3.Text + "'where TcNoA ='"+tcnoA+"'";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cfakA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cfakA.SelectedIndex != -1)
                {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Parts where FacultyID =" + cfakA.SelectedValue, conn);
                da.Fill(dt);
                comboBox1.ValueMember = "PartsId";
                comboBox1.DisplayMember = "PartsCat";
                comboBox1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
