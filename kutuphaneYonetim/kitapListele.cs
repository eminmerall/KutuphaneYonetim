using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneYonetim
{
    public partial class kitapListele : Form
    {
        public kitapListele()
        {
            InitializeComponent();
        }

        private void kitapListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneBilgiDataSet1.kitaplar' table. You can move, or remove it, as needed.
            this.kitaplarTableAdapter.Fill(this.kutuphaneBilgiDataSet1.kitaplar);

        }

        private void kitapAdTbox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "adSoyad Like '%" + kitapAdTbox.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void kitapAdTbox_TextChanged_1(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "kitapAdi Like '%" + kitapAdTbox.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void yazarAdTbox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "yazarAdi Like '%" + yazarAdTbox.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void yayinEvTbox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "yayinEviAdi Like '%" + yayinEvTbox.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void turCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "kitapTur Like '%" + turCbox.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapAdTbox.Text = "";
            yazarAdTbox.Text = "";
            yayinEvTbox.Text = "";
            turCbox.Text = "";

        }
    }
}
