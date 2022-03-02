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

namespace kutuphaneYonetim
{
    public partial class uyeKayit : Form
    {
        public uyeKayit()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=kutuphaneBilgi;Integrated Security=True");
            if (baglan.State != ConnectionState.Open)
            {
                baglan.Close();
                baglan.Open();
            }

            try
            {

                SqlCommand uyeEkle = new SqlCommand("Insert Into kullanicilar (tcKimlik, adSoyad, telefon, ePosta, uyelikTarih) VALUES (@tcKimlik, @adSoyad, @telefon, @ePosta, @uyelikTarih)", baglan);
                uyeEkle.Parameters.AddWithValue("@tcKimlik", (tcNoTBox.Text));
                uyeEkle.Parameters.AddWithValue("@adSoyad", (adSadTBox.Text));
                uyeEkle.Parameters.AddWithValue("@telefon", (telTBox.Text));
                uyeEkle.Parameters.AddWithValue("@ePosta", (ePosTbox.Text));
                uyeEkle.Parameters.AddWithValue("@uyelikTarih", Convert.ToDateTime((uyeTarihDTPicker.Text)));

                uyeEkle.ExecuteNonQuery();
                MessageBox.Show("Üye Başarıyla Eklendi");
                baglan.Close();

                tcNoTBox.Text = "";
                adSadTBox.Text = "";
                telTBox.Text = "";
                ePosTbox.Text = "";
                uyeTarihDTPicker.Text = "";


            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu");

            }

        }

        
    }
}
