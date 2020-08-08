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
    public partial class otoparkyeri_sec : Form
    {
        public otoparkyeri_sec()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=MYPC;Initial Catalog=otopark;Integrated Security=True");
        DataTable takip = new DataTable();
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

        private void otoparkyeri_sec_Load(object sender, EventArgs e)
        {
            Datagrid();
            DoluAraçYerleri();
            KayıtlıPlakalar();
            
        }

        private void KayıtlıPlakalar()
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("arac_sahibi_göster", baglanti);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                comboplaka.Items.Add(read["plaka_no"].ToString());
            }
            baglanti.Close();
        }

        private void DoluAraçYerleri()
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("aracdurumu_dolu_göster", baglanti);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                comboparkyeri.Items.Add(read["park_yeri"].ToString());
            }
            baglanti.Close();
        }

        private void Datagrid()
        {
            // TODO: Bu kod satırı 'otoparkDataSet.arac_sahibi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

            baglanti.Open();
            SqlCommand komut = new SqlCommand("aracdurumu_aracsahibi_baglantı", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            komut.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboplaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("arac_sahibi_plaka_secimi'"+comboplaka.SelectedItem+"'", baglanti);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                textparkyeri1.Text = read["park_yeri"].ToString();            
            }
            baglanti.Close();
        }

        private void comboparkyeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("arac_sahibi_parkyeri_secimi'" + comboparkyeri.SelectedItem + "'", baglanti);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                textparkyeri2.Text = read["park_yeri"].ToString();
                textad.Text = read["ad"].ToString();
                textsoyad.Text = read["soyad"].ToString();
                textmarka.Text = read["arac_marka"].ToString();
                textplaka.Text = read["plaka_no"].ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("plaka_sil'"+textplaka.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("aracdurumubos_güncelle'" + textparkyeri2.Text + "'", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Çıkışı yapıldı.");
            foreach(Control item in groupBox2.Controls)
            {
                if (item is TextBox) 
                {
                    item.Text = "";
                    textparkyeri1.Text = "";
                    comboparkyeri.Text = "";
                    comboplaka.Text = "";
                }
            }
            comboplaka.Items.Clear();
            comboparkyeri.Items.Clear();
            DoluAraçYerleri();
            KayıtlıPlakalar();
            Datagrid();
        }
    }
}
