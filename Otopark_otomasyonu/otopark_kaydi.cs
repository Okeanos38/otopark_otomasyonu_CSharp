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
    public partial class otopark_kaydi : Form
    {
        public otopark_kaydi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MYPC;Initial Catalog=otopark;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void otopark_kaydi_Load(object sender, EventArgs e)
        {
            BoşAraçlar(); //methodlar
            Marka();
            renk();

        }

        private void renk()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("renkbilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textrenk.Items.Add(read["renk"].ToString());
            }
            baglanti.Close();
        }

        private void Marka()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textmarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BoşAraçlar()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("park_yeri_bos", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                comboparkyeri.Items.Add(read["park_yeri"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

                SqlCommand komut = new SqlCommand("arac_sahibi_kayit", baglanti);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@tc_kimlik",texttc.Text);
                komut.Parameters.AddWithValue("@ad", textad.Text);
                komut.Parameters.AddWithValue("@soyad", textsoyad.Text);
                komut.Parameters.AddWithValue("@cep_telefonu", texttelefon.Text);
                komut.Parameters.AddWithValue("@plaka_no", textplaka.Text);
                komut.Parameters.AddWithValue("@arac_marka", textmarka.Text);
                komut.Parameters.AddWithValue("@arac_renk", textrenk.Text);
                komut.Parameters.AddWithValue("@park_yeri", comboparkyeri.Text);
                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("aracdurumu_güncelle'"+comboparkyeri.SelectedItem+"'", baglanti);
                komut2.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi gerçekleşti");
                comboparkyeri.Items.Clear();
                BoşAraçlar();
                foreach (Control item in aracsahip.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in aracsahiparac.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in aracsahiparac.Controls)
                {
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("İşlem sırasında hata oluştu" + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand("arac_sahibi_güncelle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@tc_kimlik", texttc.Text);
                komut.Parameters.AddWithValue("@ad", textad.Text);
                komut.Parameters.AddWithValue("@soyad", textsoyad.Text);
                komut.Parameters.AddWithValue("@cep_telefonu", texttelefon.Text);
                komut.Parameters.AddWithValue("@plaka_no", textplaka.Text);
                komut.Parameters.AddWithValue("@arac_marka", textmarka.Text);
                komut.Parameters.AddWithValue("@arac_renk", textrenk.Text);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Güncelleme İşlemi gerçekleşti");
                BoşAraçlar();
                foreach (Control item in aracsahip.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in aracsahiparac.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in aracsahiparac.Controls)
                {
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında hata oluştu" + hata.Message);
            }
        }

         private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                SqlCommand komut = new SqlCommand("arac_sahibi_sil", baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@tc_kimlik", texttc.Text);
                komut.ExecuteNonQuery();
                
                SqlCommand komut2 = new SqlCommand("aracdurumubos_güncelle'" + comboparkyeri.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt Silindi.");
                comboparkyeri.Items.Clear();
                BoşAraçlar();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            marka Marka = new marka();
            Marka.ShowDialog();
        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            renk Renk = new renk();
            Renk.ShowDialog();
        }

        private void textmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("markabilgileri", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                textmarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void textrenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("renkbilgileri", baglanti);
            komut2.CommandType = CommandType.StoredProcedure;
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                textrenk.Items.Add(read["renk"].ToString());
            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand("arac_sahibi_sil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@tc_kimlik", texttc.Text);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Silme İşlemi gerçekleşti");
                BoşAraçlar();
                foreach (Control item in aracsahip.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında hata oluştu" + hata.Message);
            }
        }
    }
}
