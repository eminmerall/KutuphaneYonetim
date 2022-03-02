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
    public partial class yazarKayit : Form
    {
        public yazarKayit()
        {
            InitializeComponent();
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

                SqlCommand yazarEkle = new SqlCommand("Insert Into yazarlar (yazarAdSoyad,yazarDtarihi) VALUES (@yazarAdSoyad,@yazarDtarihi)", baglan);
                yazarEkle.Parameters.AddWithValue("@yazarAdSoyad", (yazarAdTbox.Text));
                yazarEkle.Parameters.AddWithValue("@yzrDTarihDTPicker", (yazarAdTbox.Text));
                yazarEkle.ExecuteNonQuery();
                MessageBox.Show("Yazar başarıyla eklendi");
                baglan.Close();
                yazarAdTbox.Text = "";
            }

            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }
    }
}
