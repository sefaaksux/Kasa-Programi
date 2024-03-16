using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KasaProgramı
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
                if (cmb_odemeYontemi.Items.Count == 0)
                {
                    // ComboBox boşsa yapılacak işlemler
                    MessageBox.Show("Ödeme yöntemleri bulunamadı. Lütfen önce bir ödeme yöntemi ekleyin. (Ayarlar - Ödeme Yöntemleri kısmından ekleyebilirsiniz) )");
                }
                else
                {

                
                decimal tutar = Convert.ToDecimal(txt_tutar.Text);
                string aciklama = txt_aciklama.Text;
                int odemeYontemi = (int)cmb_odemeYontemi.SelectedValue;
                DateTime tarih = dtp_tarih.Value;
                
                if (odemeYontemi == 0)
                {
                    MessageBox.Show("LÜTFEN BİR ÖDEME YÖNTEMİ SEÇİNİZ ! ","ÖDEME YÖNTEMİ",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult sonuc = MessageBox.Show("PARA GİRİŞİNİ ONAYLIYOR MUSUNUZ ?", "PARA GİRİŞİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (sonuc == DialogResult.Yes)
                    {
                        // Para Girişi
                        _transactionService.AddIncome(tutar, tarih, aciklama, odemeYontemi);

                        // Veritabanına değişiklikleri kaydet
                        _context.SaveChanges();

                        MessageBox.Show("Para girişi başarıyla kaydedildi.");
                        temizle();
                    }
                    else
                    {
                        temizle();
                    }
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

        private void ParaGirisi_Load(object sender, EventArgs e)
        {
            cmb_odemeYontemi.SelectedIndex = 0;
            OdemeYontemleriniComboBoxaDoldur();
        }
        private void OdemeYontemleriniComboBoxaDoldur()
        {
            cmb_odemeYontemi.Items.Clear();

            var odemeYontemleri = _context.PaymentMethods.ToList();

            
            cmb_odemeYontemi.DisplayMember = "MethodName";
            cmb_odemeYontemi.ValueMember = "MethodID";
            cmb_odemeYontemi.DataSource = odemeYontemleri;
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            ParaGirisListele paraGirisi = new ParaGirisListele();
            paraGirisi.Show();
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
