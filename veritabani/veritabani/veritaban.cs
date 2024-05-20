using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
namespace veritabani
{
    internal class veritaban
    {
      static  SqlConnection con;
       static SqlDataAdapter da;
        static SqlDataReader dr;
       static SqlCommand cmd;
      static  DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-62UBN2T\\SQLEXPRESS03;Initial Catalog=deneme;Integrated Security=True";
        public static bool baglantidurum()
           //vt baglanti kontrol
        {
            using (con = new SqlConnection(SqlCon))
            {
                try
                {
                    con.Open();

                 //   System.Windows.Forms.MessageBox.Show("baglandi");

                    return true;
                }
                catch (SqlException exp)
                {
                    System.Windows.Forms.MessageBox.Show(exp.Message);
                    return false;
                }
            }
        }
           
     public  static DataGridView griddoldur ( DataGridView dataGridView1,string sqlselectsorgu)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sqlselectsorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, sqlselectsorgu);
            dataGridView1.DataSource = ds.Tables[sqlselectsorgu];
            con.Close();
            return dataGridView1;
                 

        }
        public static void komutyolla(string sql)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static bool LoginKontrol(string kullaniciAdi,string sifre)
        {
            string sorgu = "select *from tbl_login where kullanici=@user and sifre=@pass";

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciAdi);
            cmd.Parameters.AddWithValue("@pass", sifre);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //MessageBox.Show("Tebrikler Giriş Başarılı");
                con.Close();
                return true;
              
            }

            else
            {
                con.Close();
                return false;
                //MessageBox.Show("Kullanıcı yada Şifre Hatalı");
                //kullaniciAdi.Clear();
                //sifre.Clear();
                //kullaniciAdi.Focus();

            }
           
        

        }
    }
}
