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
    public partial class emanetEkle : Form
    {
        public emanetEkle()
        {
            InitializeComponent();
        }



        private void emanetEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneBilgiDataSet5.kullanicilar' table. You can move, or remove it, as needed.
            this.kullanicilarTableAdapter2.Fill(this.kutuphaneBilgiDataSet5.kullanicilar);
            // TODO: This line of code loads data into the 'kutuphaneBilgiDataSet4.kullanicilar' table. You can move, or remove it, as needed.
            this.kullanicilarTableAdapter1.Fill(this.kutuphaneBilgiDataSet4.kullanicilar);
            // TODO: This line of code loads data into the 'kutuphaneBilgiDataSet3.kitaplar' table. You can move, or remove it, as needed.
            this.kitaplarTableAdapter.Fill(this.kutuphaneBilgiDataSet3.kitaplar);





        }
        

        private void uyeAdTbox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "adSoyad Like '%" + uyeAdTbox.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void uyeTelTbox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "telefon Like '%" + uyeTelTbox.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void kitapAdTbox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = "kitapAdi Like '%" + kitapAdTbox.Text + "%'";
            dataGridView2.DataSource = bs;
        }

        private void yazarAdTbox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = "yazarAdi Like '%" + yazarAdTbox.Text + "%'";
            dataGridView2.DataSource = bs;
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

            

                SqlCommand emanetEkle = new SqlCommand("Insert Into emanetler (KitapID, kullaniciID, emanetVermeTarih) VALUES (@KitapID, @kullaniciID, @emanetVermeTarih)", baglan);
                emanetEkle.Parameters.AddWithValue("@KitapID", (kitapIdTbox.Text));
                emanetEkle.Parameters.AddWithValue("@kullaniciID", (uyeIdTbox.Text));
                emanetEkle.Parameters.AddWithValue("@emanetVermeTarih",Convert.ToDateTime(dateTimePicker1.Text));
                emanetEkle.ExecuteNonQuery();
                MessageBox.Show("Kitap Başarıyla Eklendi");
                baglan.Close();

                kitapIdTbox.Text = "";
                uyeIdTbox.Text = "";
            }

             catch (Exception)
            { 

            MessageBox.Show("Bir Hata Oluştu");
            }
        }
    }
}