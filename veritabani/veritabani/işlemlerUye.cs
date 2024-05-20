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
    public partial class işlemlerUye : Form
    {
        public işlemlerUye()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd,cmd1;
        DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-62UBN2T\\SQLEXPRESS03;Initial Catalog=deneme;Integrated Security=True";
        public int urunId;
        void griddoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select  uID,uAd,uFiyat from tbl_urunler where uStok>0  ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_urunler");
            dataGridView1.DataSource = ds.Tables["tbl_urunler"];
            con.Close();

        }
        private void işlemlerUye_Load(object sender, EventArgs e)
        {
            griddoldur();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ürünler";
            comboBox1.SelectedIndex = 0;

        }



        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

         urunId =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            label_urun.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label_fiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           // dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        //private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        //{
        //    if(maskedTextBox1.Text != "")
        //   {
        //        label_tutar.Text =( Convert.ToDouble(maskedTextBox1.Text) * Convert.ToDouble(label_fiyat.Text)).ToString();
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            string sql = "insert into tbl_islemler (islemTutar,islemTarih,islmeAciklama,islemBirim,username,uID) values (@tutar,@tarih,@aciklama,@birim,@user,@uID)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@tutar",Convert.ToDouble( label_tutar.Text));
            cmd.Parameters.AddWithValue("@aciklama", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@birim", Convert.ToDouble(comboBox1.Text));
            cmd.Parameters.AddWithValue("@user", login.kullanicisassion);
            cmd.Parameters.AddWithValue("@uID", urunId);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
            cmd1 = new SqlCommand();
            sql = "update  tbl_urunler set  uStok-=@adet where uID=@uID";
            cmd1.Parameters.AddWithValue("@uID", urunId);
            cmd1.Parameters.AddWithValue("@adet", Convert.ToDouble(comboBox1.Text.Trim()));
            con.Open();
            cmd1.Connection = con;
            cmd1.CommandText = sql;
            cmd1.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text!="seçiniz...")
            label_tutar.Text = (Convert.ToDouble(comboBox1.Text) * Convert.ToDouble(label_fiyat.Text)).ToString();

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
