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

namespace Otopark_otomasyonu
{
    public partial class renk : Form
    {
        public renk()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=MYPC;Initial Catalog=otopark;Integrated Security=True");
        private void renk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("renk_kayit", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@renk", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Renk Eklendi.");
        }
    }
}
