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
    public partial class kitapKayit : Form
    {
        public kitapKayit()
        {
            InitializeComponent();
        }

        private void ktpKydtButton_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=kutuphaneBilgi;Integrated Security=True");
            if (baglan.State != ConnectionState.Open)
            {
                baglan.Close();
                baglan.Open();
            }

           try
            {                      

            SqlCommand kitapEkle = new SqlCommand("Insert Into kitaplar (kitapAdi, yazarAdi, yayinEviAdi, kitapTur) VALUES (@kitapAdi, @yazarAdi, @yayinEviAdi, @kitapTur)", baglan);
            kitapEkle.Parameters.AddWithValue("@kitapAdi", (kitapAdTbox.Text));
            kitapEkle.Parameters.AddWithValue("@yazarAdi", (yazarAdCbox.Text));
            kitapEkle.Parameters.AddWithValue("@yayinEviAdi", (yayinEviCbox.Text));
            kitapEkle.Parameters.AddWithValue("@kitapTur", (kitapTurCbox.Text));
            kitapEkle.ExecuteNonQuery();
            MessageBox.Show("Kitap Başarıyla Eklendi");
            baglan.Close();

            kitapAdTbox.Text = "";
            yazarAdCbox.Text = "";
            yayinEviCbox.Text = "";
            kitapTurCbox.Text = "";
            }

            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }


        }

        private void kitapKayit_Load(object sender, EventArgs e)
        {        
                SqlConnection Baglan = new SqlConnection();
            Baglan.ConnectionString = "Data Source=.;Initial Catalog=kutuphaneBilgi;Integrated Security=SSPI";
                SqlCommand yazarKomut = new SqlCommand();
            yazarKomut.CommandText = "SELECT * FROM yazarlar";
            yazarKomut.Connection = Baglan;
            yazarKomut.CommandType = CommandType.Text;

                SqlDataReader yazarDr;
            Baglan.Open();
            yazarDr = yazarKomut.ExecuteReader();
                while (yazarDr.Read())
                {
                yazarAdCbox.Items.Add(yazarDr["yazarAdSoyad"]);
                }
            yazarDr.Close();


            SqlCommand yayinEviKomut = new SqlCommand();
            yayinEviKomut.CommandText = "SELECT * FROM yayinEvleri";
            yayinEviKomut.Connection = Baglan;
            yayinEviKomut.CommandType = CommandType.Text;

            SqlDataReader yayinEviDr;
            yayinEviDr = yayinEviKomut.ExecuteReader();
            while (yayinEviDr.Read())
            {
                yayinEviCbox.Items.Add(yayinEviDr["yayinEviAdi"]);
            }
            Baglan.Close();


        }

        private void yzrEkleButton_Click(object sender, EventArgs e)
        {
            yazarKayit formGec = new yazarKayit();
            formGec.Show();
        }

        private void yynEvEkle_Click(object sender, EventArgs e)
        {
            yayinEviKayit form2Gec = new yayinEviKayit();
            form2Gec.Show();
        }
    }
    
}
