using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabani
{
    public partial class login : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-62UBN2T\\SQLEXPRESS03;Initial Catalog=deneme;Integrated Security=True";
        public int denemeSayisi=0;
        public static string kullanicisassion = "";
        public login()
        {
            InitializeComponent();
            //  da = new SqlDataAdapter("select *from tbl_login ", con);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            //Login();
            //string sorgu = "select *from tbl_login where kullanici='"+textBox1.Text+"' and sifre='"+textBox2.Text+"'";
            //con = new SqlConnection(SqlCon);
            //cmd = new SqlCommand(sorgu, con);
            //con.Open();
            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    MessageBox.Show("Tebrikler Giriş Başarılı");
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı yada Şifre Hatalı");
            //    textBox1.Clear();
            //    textBox2.Clear();
            //    textBox1.Focus();

            //}
            //con.Close();
          /*  if (   veritaban.LoginKontrol(textBox1.Text, textBox2.Text) ){
                MessageBox.Show("Tebrikler! Giriş Başarılı");
                this.Hide();
                kullanicisassion = textBox1.Text;
                if (kullanicisassion == "beyza")
                {
                    //yoneticiyse 
                    işlemlerYönetici a = new işlemlerYönetici();
                    a.Show();

                }
                else
                {
                    //kullaniciysa
                    işlemlerUye a = new işlemlerUye();
                    a.Show();
                }
              
            }
            else
            {
                denemeSayisi++;
                if (denemeSayisi == 3)
                {
                    MessageBox.Show("3 defa hatali giris yaptınız");
                    Application.Exit();
                }
            }*/

        }
        public  void Login()
        {
            string sorgu = "select *from tbl_login where kullanici=@user and sifre=@pass";

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı yada Şifre Hatalı");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            con.Close();

        }

        private void login_Load(object sender, EventArgs e)
        {
          
        }
    }
}
