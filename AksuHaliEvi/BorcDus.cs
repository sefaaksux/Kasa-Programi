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
    public partial class BorcDus : Form
    {
        private readonly MyDbContext _context;
        private readonly TransactionService _transactionService;
        public BorcDus()
        {
            InitializeComponent();
            _context = new MyDbContext();
            _transactionService = new TransactionService(_context);
        }

        private void textleriDoldur()
        {         
            if (dataGridView1.RowCount > 0)
            {
                txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_tutar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                msk_telNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_aciklama.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dtp_tarih.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();             
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }
        public void kayitlariGetir()
        {
            SetFontAndColors();
            var query = from item in _context.Debts
                        select new
                        {
                            ID = item.DebtID,
                            İSİM = item.Name,
                            BORÇ = item.Amount,
                            TELEFON = item.Phone,
                            AÇIKLAMA = item.Description,
                            TARİH = item.Date
                        };
            dataGridView1.DataSource = query.ToList();
        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
        }
        private void BorcDus_Load(object sender, EventArgs e)
        {
            
            kayitlariGetir();
        }

        private void txt_aranan_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_aranan.Text.ToLower();

            var query = from item in _context.Debts
                        where item.Name.ToLower().Contains(aranan)
                        select new
                        {
                            ID = item.DebtID,
                            İSİM = item.Name,
                            BORÇ = item.Amount,
                            TELEFON = item.Phone,
                            AÇIKLAMA = item.Description,
                            TARİH = item.Date
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_aranan.Text = "";
        }

        private void temizle()
        {
            
            txt_aciklama.Text = "";
            txt_dusulecekTutar.Text = "";
            txt_isim.Text = "";
            msk_telNo.Text = "";
            txt_tutar.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_dus_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dusulecekTutar.Text))
            {
                MessageBox.Show("LÜTFEN DÜŞÜŞLECEK TUTARI GİRİN!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal tutar = Convert.ToInt32(txt_dusulecekTutar.Text);
                DialogResult result = MessageBox.Show(tutar + " TL Düşmek istediğinize emin misiniz?", "BORÇ DÜŞME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string isim = txt_isim.Text;

                    string telno = msk_telNo.Text;

                    bool donenDeger = _transactionService.DownDebt(dataGridView1, tutar);
                    if (donenDeger)
                    {
                        MessageBox.Show("Borçtan " + tutar +" TL düşüldü ve para girişine eklendi.");
                        _transactionService.AddIncome(tutar, DateTime.Now, isim + " Kişisinden düşülen borç. TELEFON NO: " + telno, 5);
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("HATA");
                    }

                    _context.SaveChanges();
                    kayitlariGetir();
                }
                else
                {
                    temizle();
                }




            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_isim.Text) && string.IsNullOrEmpty(txt_tutar.Text) && string.IsNullOrEmpty(txt_aciklama.Text))
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUN!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("GÜNCELLEME YAPMAK İSTEDİĞİNİZE EMİN MİSİNİZ?", "GÜNCELLEME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string isim = txt_isim.Text;
                    string telno = msk_telNo.Text;
                    string aciklama = txt_aciklama.Text;
                    decimal tutar = Convert.ToDecimal(txt_tutar.Text);
                    DateTime date = dtp_tarih.Value;

                    _transactionService.UpdateDebt(dataGridView1, isim, tutar, date, aciklama, telno);
                    kayitlariGetir();
                }
                else
                {
                    temizle();
                }
                
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_isim.Text) && string.IsNullOrEmpty(txt_tutar.Text) && string.IsNullOrEmpty(txt_aciklama.Text))
            {
                MessageBox.Show("LÜTFEN SİLİNECEK KAYIDI SEÇİN !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DialogResult result2 = MessageBox.Show("PARA GİRİŞ KAYITLARINA EKLENMESİNİ İSTİYOR MUSUNUZ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result2 == DialogResult.Yes)
                    {
                        decimal tutar =Convert.ToDecimal( txt_tutar.Text);
                        string isim = txt_isim.Text;
                        string telno = msk_telNo.Text;
                        _transactionService.AddIncome(tutar, DateTime.Now, isim + " Kişisinden düşülen borç. TELEFON NO: " + telno, 5);
                        _transactionService.DeleteDebt(dataGridView1);
                        MessageBox.Show("KAYIT SİLİNDİ VE PARA GİRİŞ KAYITLARINA EKLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        kayitlariGetir();
                        temizle();
                    }
                    else
                    {
                        _transactionService.DeleteDebt(dataGridView1);
                        MessageBox.Show("KAYIT SİLİNDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        kayitlariGetir();
                        temizle();
                    }


                    
                }
                else
                {
                    
                }

            }
        }
    }
}
