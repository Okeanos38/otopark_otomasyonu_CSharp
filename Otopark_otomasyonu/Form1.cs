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
    public partial class Form1 : Form
    {   

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=MYPC;Initial Catalog=otopark;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            arac_otopark_yerleri park = new arac_otopark_yerleri();
            park.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            otopark_kaydi kayit = new otopark_kaydi();
            kayit.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            otoparkyeri_sec otoparksec = new otoparkyeri_sec();
            otoparksec.Show();
            this.Hide();
        }
    }
}
