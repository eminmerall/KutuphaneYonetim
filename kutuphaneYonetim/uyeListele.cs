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
    public partial class uyeListele : Form
    {
        public uyeListele()
        {
            InitializeComponent();
        }

        private void uyeListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneBilgiDataSet.kullanicilar' table. You can move, or remove it, as needed.
            this.kullanicilarTableAdapter.Fill(this.kutuphaneBilgiDataSet.kullanicilar);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "tcKimlik Like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "adSoyad Like '%" + textBox3.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "telefon Like '%" + textBox4.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "ePosta Like '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = bs;
        }
    }
}
