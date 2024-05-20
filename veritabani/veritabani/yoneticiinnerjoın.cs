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
    public partial class yoneticiinnerjoın : Form
    {
        public yoneticiinnerjoın()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd, cmd1;
        DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-62UBN2T\\SQLEXPRESS03;Initial Catalog=deneme;Integrated Security=True";
        public int urunId;
        public string sqlSorgu;
        void griddoldur(string sql)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_urunler");
            dataGridView1.DataSource = ds.Tables["tbl_urunler"];
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void yoneticiinnerjoın_Load(object sender, EventArgs e)
        {

            sqlSorgu = "select  tbl_urunler.* ,tbl_islemler.* from tbl_urunler inner join tbl_islemler on tbl_urunler.uID= tbl_islemler.uID ";
                griddoldur(sqlSorgu);
            
        }
    }
}
