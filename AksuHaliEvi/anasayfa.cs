using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AksuHaliEvi
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
           
        }

        private void hedefDegistir(Form Frm)
        {
            hedefPanel.Controls.Clear();
            Frm.MdiParent = this;
            hedefPanel.Controls.Add(Frm);
            Frm.Show();
        }

        private void btn_paragirisisayfa_Click_1(object sender, EventArgs e)
        {
            ParaGirisi frm = new ParaGirisi();
            hedefDegistir(frm);          
        }

        private void btn_paracikisisayfa_Click_1(object sender, EventArgs e)
        {
            
            ParaCikisi paraCikisi = new ParaCikisi();
            hedefDegistir(paraCikisi);
            
        }
    }
}
