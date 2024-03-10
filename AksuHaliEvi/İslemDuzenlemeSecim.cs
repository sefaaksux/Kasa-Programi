using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasaProgramı
{
    public partial class İslemDuzenlemeSecim : Form
    {
        public İslemDuzenlemeSecim()
        {
            InitializeComponent();
        }

        private void btn_paragirisduzenle_Click(object sender, EventArgs e)
        {
            DuzenleParaGiris duzenleParaGiris = new DuzenleParaGiris();
            duzenleParaGiris.Show();
            this.Hide();
        }

        private void btn_paracikisduzenle_Click(object sender, EventArgs e)
        {
            DuzenleParaCikis duzenleParaCikis = new DuzenleParaCikis();
            duzenleParaCikis.Show();
            this.Hide();
        }
    }
}
