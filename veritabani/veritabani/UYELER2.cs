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
    public partial class UYELER2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-62UBN2T\\SQLEXPRESS03;Initial Catalog=deneme;Integrated Security=True";

        public UYELER2()
        {
            InitializeComponent();
        }

        private void UYELER2_Load(object sender, EventArgs e)
        {
            veribaglantilari();
        }
        public void veribaglantilari()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from tbl_login",con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            //   da.Fill(ds, "tbl_login"); aynı birden fazla tablo varsa boyle
            con.Close();
           bindingSource1.DataSource = ds.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;
            label1.DataBindings.Add(new Binding("text", bindingSource1,"kID"));
            textBox1.DataBindings.Add(new Binding("text", bindingSource1,"kullanici"));
            textBox2.DataBindings.Add(new Binding("text", bindingSource1,"sifre"));
            dateTimePicker1.DataBindings.Add(new Binding("text", bindingSource1,"tarih"));

        }
    }
}
