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
    public partial class kullaniciGiris : Form
    {
        public kullaniciGiris()
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
            SqlCommand kayitOku = new SqlCommand("Select * from sistemYoneticiler Where yoneticiKlAd='" + kAdiTextbox.Text + "' AND yoneticiSifre='" + sifreTextbox.Text + "'", baglan);
            SqlDataReader oku = kayitOku.ExecuteReader();
            if (oku.Read())
            {
                baglan.Close();
                baglan.Dispose();

                anasayfa form1gec = new anasayfa();
                this.Hide();
                form1gec.Show();
            }


        }

    }
}
