using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Otopark_otomasyonu
{
    public partial class arac_otopark_yerleri : Form
    {
        public arac_otopark_yerleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MYPC;Initial Catalog=otopark;Integrated Security=True");
        private void arac_otopark_yerleri_Load(object sender, EventArgs e)
        {

            BoşAraçlar();

            plakayı_göster();
        }

        private void plakayı_göster()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("arac_sahibi_göster", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            komut.CommandType = CommandType.StoredProcedure;
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["park_yeri"].ToString())
                        {
                             item.Text= read["plaka_no"].ToString();
                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void BoşAraçlar()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("arac_durumu_göster",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach(Control item in Controls)
                {
                    if(item is Button)
                    {
                        if(item.Text==read["park_yeri"].ToString() && read["durumu"].ToString() == "DOLU")
                        {
                            item.BackColor = Color.Red;
                        }
                        if (item.Text == read["park_yeri"].ToString() && read["durumu"].ToString() == "BOŞ")
                        {
                            item.BackColor = Color.Green;
                        }
                    }
                }
            }
            
            baglanti.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
