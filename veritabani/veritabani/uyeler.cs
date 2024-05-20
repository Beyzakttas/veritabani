using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabani
{
    public partial class uyeler : Form
    {
        public uyeler()
        {
            InitializeComponent();
        }

        private void uyeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'denemeDataSet.tbl_login' table. You can move, or remove it, as needed.
            this.tbl_loginTableAdapter.Fill(this.denemeDataSet.tbl_login);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox1.Text;
            label7.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
