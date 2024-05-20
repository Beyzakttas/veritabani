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
    public partial class işlemlerYönetici : Form
    {
        public işlemlerYönetici()
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
            da = new SqlDataAdapter(sql , con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_urunler");
            dataGridView1.DataSource = ds.Tables["tbl_urunler"];
            con.Close();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {


                if (radioButton1.Checked)
                {//isime gore
                    if (radioButton5.Checked)
                    {
                        sqlSorgu = "select *from tbl_urunler where uAd like '%" + textBox1.Text + "%' order by uAd asc";
                        griddoldur(sqlSorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sqlSorgu = "select *from tbl_urunler where uAd like '%" + textBox1.Text + "%' order by uAd desc";
                        griddoldur(sqlSorgu);
                    }
                }
                else if (radioButton2.Checked)
                {
                    //stok miktari
                    if (radioButton5.Checked)
                    {
                        sqlSorgu = "select *from tbl_urunler where uStok>" + textBox1.Text;
                        griddoldur(sqlSorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sqlSorgu = "select *from tbl_urunler where uStok<" + textBox1.Text;
                        griddoldur(sqlSorgu);
                    }
                }
                else if (radioButton3.Checked)
                {
                }
                else if (radioButton4.Checked)
                {
                    //son kullanma tarihi
                    if (radioButton5.Checked)
                    {
                        //  sqlSorgu = "select *from tbl_urunler where uFiyat>" + textBox1.Text + " 0.9 and uFiyat<" + textBox1.Text + "1.1 order bu uFiyat asc";
                        sqlSorgu = "select *from tbl_urunler where uFiyat between" + textBox1.Text + " 0.9 and " + textBox1.Text + "1.1 order by uFiyat asc";
                        griddoldur(sqlSorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sqlSorgu = "select *from tbl_urunler where uFiyat between" + textBox1.Text + " 0.9 and " + textBox1.Text + "1.1 order by uFiyat desc";
                        griddoldur(sqlSorgu);
                    }
                    //  sqlSorgu = "select *from tbl_urunler where  uAd uFiyat is null"; degerinin olmasi durumu
                    //  sqlSorgu = "select *from tbl_urunler where  uAd uFiyat is not null"; degerinin olmamasi durumu
                    // distinc tekrar eden sayılari inaktif eder

                }
            }
        }

        private void işlemlerYönetici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denemeDataSet1.tbl_urunler' table. You can move, or remove it, as needed.
            this.tbl_urunlerTableAdapter.Fill(this.denemeDataSet1.tbl_urunler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                //tarih
                if (radioButton5.Checked)
                {
                    sqlSorgu = "select *from tbl_urunler where uSTT >'" + dateTimePicker1.Value.ToString() + "'  and uSTT< '" + dateTimePicker2.Value.ToString() + " 'order by uSTT asc";
                    griddoldur(sqlSorgu);
                }
                else if (radioButton6.Checked)
                {
                    sqlSorgu = "select *from tbl_urunler where uSTT >'" + dateTimePicker1.Value.ToString() + "'  and uSTT< '" + dateTimePicker2.Value.ToString() + " 'order by uSTT desc";
                    griddoldur(sqlSorgu);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
