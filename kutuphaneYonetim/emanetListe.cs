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
    public partial class emanetListe : Form
    {
        public emanetListe()
        {
            InitializeComponent();
        }

        private void emanetListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneBilgiDataSet6.emanetler' table. You can move, or remove it, as needed.
            this.emanetlerTableAdapter.Fill(this.kutuphaneBilgiDataSet6.emanetler);

        }
    }
}
