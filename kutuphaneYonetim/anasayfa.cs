﻿using System;
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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapKayit form1gec = new kitapKayit();
            form1gec.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            uyeKayit form2gec = new uyeKayit();
            form2gec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapListele form4gec = new kitapListele();
            form4gec.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uyeListele form3gec = new uyeListele();
            form3gec.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            emanetEkle form4gec = new emanetEkle();
            form4gec.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            emanetListe form5gec = new emanetListe();
            form5gec.Show();
        }
    }
}
