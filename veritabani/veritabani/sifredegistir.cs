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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veritabani
{
    public partial class sifredegistir : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        public static string SqlCon = "Data Source=DESKTOP-62UBN2T\\SQLEXPRESS03;Initial Catalog=deneme;Integrated Security=True";
        public int sonuc=0;
        public sifredegistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captcha .Text== sonuc.ToString())
            {
                mesaj.Text = "";
                if (yenisifre.Text == yenitekrer.Text)
                {

                }
                else
                {
                    mesaj.Text = "Şifreler uyuşmuyor";
                    capchaolustur();

                }
            }
            else
            {
                mesaj.Text = "captcha hatalı!";
                capchaolustur();

            }
        }
        public  bool eskisifrekontrol()
        {

            string sorgu = "select sifre from tbl_login where kullanici=@user and sifre=@pass";

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", login.kullanicisassion);
            cmd.Parameters.AddWithValue("@pass", eskisifre.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //eski sifre dogruysa yapılacaklar hata veriyor
                 string sql = "update tbl_login  set sifre ='"+yenisifre.Text+"' ";
                 veritaban.komutyolla(sql);
                MessageBox.Show("sifre degistirme basarili");
                mesaj.Text="sifreniz basari ile degistirildi";
            }
            else
            {

                mesaj .Text= "eski sifre hatali";
                capchaolustur();

            }
            con.Close();
            return true;

        }
        public void capchaolustur()
        {
            Random r = new Random();
            int ilk = r.Next(0, 100);
            int ikinci = r.Next(0, 50);
            sonuc = ilk + ikinci;
            labelcaptcha.Text = ilk.ToString() + "+" + ikinci.ToString() + "=";
            // mesaj.Text = login.kullanicisassion;
            captcha.Clear();
        }
        private void sifredegistir_Load(object sender, EventArgs e)
        {
            capchaolustur();
           
        }
    }
}
