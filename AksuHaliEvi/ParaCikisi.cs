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
    public partial class ParaCikisi : Form
    {
        private readonly MyDbContext _context;
        private readonly TransactionService _transactionService;
        public ParaCikisi()
        {
            InitializeComponent();
            _context = new MyDbContext();
            _transactionService = new TransactionService(_context);
        }

        private void btn_paraCikis_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_tutar.Text) || string.IsNullOrEmpty(txt_aciklama.Text))
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ !", "EKSİK PARAMETRE", MessageBoxButtons.OK);
            }
            else
            {
                decimal tutar = Convert.ToDecimal(txt_tutar.Text);
                string aciklama = txt_aciklama.Text;
                int odemeYontemi = cmb_odemeYontemi.SelectedIndex;
                DateTime tarih = dtp_tarih.Value;

                if(odemeYontemi == 0)
                {
                    MessageBox.Show("LÜTFEN BİR ÖDEME YÖNTEMİ SEÇİNİZ ! ", "ÖDEME YÖNTEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult sonuc = MessageBox.Show("PARA ÇIKIŞINI ONAYLIYOR MUSUNUZ ?", "PARA ÇIKIŞI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (sonuc == DialogResult.Yes)
                    {
                        // Para Girişi
                        _transactionService.AddExpense(tutar, tarih, aciklama, odemeYontemi);

                        // Veritabanına değişiklikleri kaydet
                        _context.SaveChanges();

                        MessageBox.Show("Para çıkışı başarıyla kaydedildi.");
                        temizle();
                    }
                    else
                    {
                        temizle();
                    }
                }        
            }
        }
        public void temizle()
        {
            txt_aciklama.Text = "";
            txt_tutar.Text = "";
            cmb_odemeYontemi.SelectedIndex = 0;
            dtp_tarih.Value = DateTime.Now;
        }
        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void ParaCikisi_Load(object sender, EventArgs e)
        {
            cmb_odemeYontemi.SelectedIndex = 0;
        }

        private void btn_islemlistele_Click(object sender, EventArgs e)
        {
            ParaCikisiListele paraCikisiListele = new ParaCikisiListele();
            paraCikisiListele.Show();

        }

        private void txt_tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // İşlemi engelle
                e.Handled = true;
            }
        }
    }
}
