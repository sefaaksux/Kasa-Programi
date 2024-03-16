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
    public partial class OdemeYöntemiEkle : Form
    {
        private readonly TransactionService _transactionService;
        private readonly MyDbContext _context;
        public OdemeYöntemiEkle()
        {
            InitializeComponent();
            _context = new MyDbContext();
            _transactionService = new TransactionService(_context);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_odemeYontemi.Text))
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ !", "EKSİK PARAMETRE", MessageBoxButtons.OK);
            }
            else
            {
                string odeme = txt_odemeYontemi.Text;
                bool deger = _transactionService.AddPaymentMethod(odeme);
                if(deger == true)
                {
                _context.SaveChanges();
                OdemeYontemiGetir();
                txt_odemeYontemi.Text = "";
                }
                else
                {
                    MessageBox.Show("Bu ödeme yöntemi zaten var!");
                }
            }
            
        }

        public void OdemeYontemiGetir()
        {
            listBox1.Items.Clear();
            var odemeYontemleri = _context.PaymentMethods.ToList();
            foreach (var item in odemeYontemleri)
            {
                listBox1.Items.Add(item.MethodName);
            }
            
        }

        private void ÖdemeYöntemiEkle_Load(object sender, EventArgs e)
        {
            OdemeYontemiGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("BU ÖDEME YÖNTEMİ İLE İLİŞKİLENDİRİLMİŞ BÜTÜN KAYITLAR GİDECEK!! SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "ÖNEMLİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialog == DialogResult.Yes)
                {
                string secilenOdemeYontemi = listBox1.SelectedItem.ToString();
                var silinecek = _context.PaymentMethods.FirstOrDefault(x => x.MethodName == secilenOdemeYontemi);
                _context.PaymentMethods.Remove(silinecek);
                _context.SaveChanges();
                txt_odemeYontemi.Text = "";
                OdemeYontemiGetir();

                }
                else
                {

                }
                
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ödeme yöntemini seçin.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                txt_odemeYontemi.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
