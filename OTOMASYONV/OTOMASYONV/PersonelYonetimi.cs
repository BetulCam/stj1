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
    public partial class PersonelYonetimi : Form
    {
        public PersonelYonetimi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=PC-BILGISAYAR\SQLEXPRESS; Database=OTOMASYON; Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        
        void gridDoldur()
        {
            da = new SqlDataAdapter("SELECT * FROM Officer",conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds,"Officer");
            dataGridView1.DataSource = ds.Tables["Officer"];
            conn.Close();
        }
        private void PersonelYonetimi_Load(object sender, EventArgs e)
        {
            gridDoldur();
            conn = new SqlConnection(@"Server = PC-BILGISAYAR\SQLEXPRESS; Database = OTOMASYON; Integrated Security = SSPI");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from FacultyS1 ORDER BY FacultyID ASC ", conn);
            da.Fill(dt);
            comboBox1.ValueMember = "FacultyID";
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.DataSource = dt;
        }

        private void ekleP_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Officer(TcNoO,NameO,LNameO,TitleO,MailO,SPhoneO,EduInfO,FacultyID) values (" + textBox4.Text + ",'" + textBox1.Text + "','" + textBox2.Text + "','" +textBox5.Text + "','" + textBox6.Text  +"','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox1.SelectedValue +"')";
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

        private void SilP_Click(object sender, EventArgs e)
        {
            var asd = dataGridView1.SelectedRows[0];

            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "delete from Officer where TcNoO = '" + asd.Cells["TcNoO"].Value + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            gridDoldur();

        }

        private void duzenleP_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection=conn;
            cmd.CommandText="update Officer set NameO='"+textBox1.Text+"',LNameO='"+textBox2.Text+"',TitleO='"+textBox5.Text+"',MailO='"+textBox6.Text+"',SPhoneO='"+textBox7.Text+"',EduInfO='"+textBox8.Text+ "'where TcNoO ='" +textBox4.Text + "'";
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
    }
}
