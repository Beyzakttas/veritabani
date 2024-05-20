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
using System.Net.Http.Headers;

namespace veritabani
{
    //
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-62UBN2T\\SQLEXPRESS03;Initial Catalog=deneme;Integrated Security=True";
        void griddoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select *from tbl_login ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_login");
            dataGridView1.DataSource = ds.Tables["tbl_login"];
            con.Close();

        }
        public Form1()
        {
            InitializeComponent();
            if (veritaban.baglantidurum())
            {
                MessageBox.Show(" veritabannına baglandi");
            }
        }
            private void Form1_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'denemeDataSet.tbl_login' table. You can move, or remove it, as needed.
                griddoldur();
            veritaban.griddoldur(dataGridView1, "select *from tbl_login ");

            }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
        //ekle
        private void button2_Click(object sender, EventArgs e)
        {
            /* con = new SqlConnection(SqlCon);
             string sql = "insert into tbl_login (kullanici,sifre,tarih) values ('" + textBox1.Text + "','" + textBox2.Text + "',#"+dateTimePicker1.Value.ToString()+"#)";
             cmd = new SqlCommand();
             con.Open();
             cmd.Connection = con;
             cmd.CommandText =sql;
             cmd.ExecuteNonQuery();
             con.Close();
             griddoldur();  */
            //con = new SqlConnection(SqlCon);
            //string sql = "insert into tbl_login (kullanici,sifre,tarih) values (@user,@pass,@tarih)";
            //cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@user", textBox1.Text);
            //cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            //cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
          
            cmd = new SqlCommand();
            string sql = "insert into tbl_login (kullanici,sifre,tarih) values (@user,@pass,@tarih)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();

        }
        public void eklemesorgu(string sql)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();

        }
        //sil
        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql = "delete from tbl_login where  kullanici=@user and sifre=@pass and kId=@idm";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            cmd.Parameters.AddWithValue("@idm", Convert.ToInt32(textBox3.Text));
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
        //guncelle
        private void button4_Click(object sender, EventArgs e)
        {
             con = new SqlConnection(SqlCon);
            string sql = "update tbl_login set  sifre='"+textBox2.Text+"' where kullanici='"+ textBox1.Text+"' and kID="+textBox3.Text;

             cmd = new SqlCommand();
             con.Open();
             cmd.Connection = con;
             cmd.CommandText = sql;
             cmd.ExecuteNonQuery();
             con.Close();
             griddoldur();
            //con = new SqlConnection(SqlCon);
            //string sql = "update  tbl_login set sifre=@pass where  kullanici=@user and kId=@idm";
            //cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@user", textBox1.Text);
            //cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            //cmd.Parameters.AddWithValue("@idm", Convert.ToInt32(textBox3.Text));
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = sql;
            //cmd.ExecuteNonQuery();
            //con.Close();
            //griddoldur();
          //  veritaban.komutyolla(sql);
        }

        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifredegistir a = new sifredegistir();
            a.ShowDialog();
        }

        private void hAZIRMODÜLİLEYAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uyeler a = new uyeler();
            a.ShowDialog();
        }

        private void kODİLEYAPILANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UYELER2 a = new UYELER2();
            a.ShowDialog();
        }

       

       

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            işlemlerUye a = new işlemlerUye();
            a.ShowDialog();
        }

        private void yöneticiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            işlemlerYönetici a = new işlemlerYönetici();
            a.ShowDialog();
        }
    }
    } 