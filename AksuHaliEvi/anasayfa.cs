using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            ParaGirisListele frm = new ParaGirisListele();
            hedefDegistir(frm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            ParaCikisiListele frm = new ParaCikisiListele();
            hedefDegistir(frm);
        }


        private void lbl_anasayfa_Click(object sender, EventArgs e)
        {
            resimgetir resimgetir = new resimgetir();
            hedefDegistir(resimgetir);
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            resimgetir resimgetir = new resimgetir();
            hedefDegistir(resimgetir);
        }

        private void btn_kasa_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
        }

        private void btn_borcGir_Click(object sender, EventArgs e)
        {
            BorcGir borcGir = new BorcGir();
            hedefDegistir(borcGir);
        }

        private void btn_borcDus_Click(object sender, EventArgs e)
        {
            BorcDus borcDus = new BorcDus();
            hedefDegistir(borcDus);
        }

        private void btn_borcListele_Click(object sender, EventArgs e)
        {
            BorcListele borcListele = new BorcListele();
            hedefDegistir(borcListele);
        }

        private void btn_islemDuzenle_Click(object sender, EventArgs e)
        {
            İslemDuzenlemeSecim islemDuzenlemeSecim = new İslemDuzenlemeSecim();
            islemDuzenlemeSecim.Show();
        }
    }
}
