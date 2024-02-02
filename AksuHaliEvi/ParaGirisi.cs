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
    public partial class ParaGirisi : Form
    {
        private readonly MyDbContext _context;
        private readonly TransactionService _transactionService;
        public ParaGirisi()
        {
            InitializeComponent();
            _context = new MyDbContext();
            _transactionService = new TransactionService(_context);
        }

        private void btn_paraGiris_Click(object sender, EventArgs e)
        {
            


            if (string.IsNullOrEmpty(txt_tutar.Text) || string.IsNullOrEmpty(txt_aciklama.Text))
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ !", "EKSİK PARAMETRE", MessageBoxButtons.OK);
            }
            else
            {
                int tutar = Convert.ToInt32(txt_tutar.Text);
                string aciklama = txt_aciklama.Text;
                int odemeYontemi = cmb_odemeYontemi.SelectedIndex;


                DialogResult sonuc = MessageBox.Show("PARA GİRİŞİNİ ONAYLIYOR MUSUNUZ ?", "PARA GİRİŞİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    // Para Girişi
                    _transactionService.AddIncome(tutar, DateTime.Now, aciklama, odemeYontemi);

                    // Veritabanına değişiklikleri kaydet
                    _context.SaveChanges();

                    MessageBox.Show("Para girişi başarıyla kaydedildi.");
                }
                else
                {
                    temizle();
                }
            }            
        }

        public void temizle()
        {
            txt_aciklama.Text = "";
            txt_tutar.Text = "";
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void ParaGirisi_Load(object sender, EventArgs e)
        {
            cmb_odemeYontemi.SelectedIndex = 0;
        }
    }
}
