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
    public partial class BorcGir : Form
    {
        private readonly MyDbContext _context;
        private readonly TransactionService _transactionService;

        public BorcGir()
        {
            InitializeComponent();
            _context = new MyDbContext();
            _transactionService = new TransactionService(_context);
        }

        public void temizle()
        {
            txt_aciklama.Text= "";
            txt_isim.Text = "";
            txt_tutar.Text = "";
            dtp_tarih.Value = DateTime.Now;
            msk_telNo.Text = string.Empty;

        }

        

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_tutar.Text) || string.IsNullOrEmpty(txt_isim.Text) || string.IsNullOrEmpty(txt_aciklama.Text) || string.IsNullOrEmpty(msk_telNo.Text))
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ !", "EKSİK PARAMETRE", MessageBoxButtons.OK);
            }
            else
            {

                DialogResult result = MessageBox.Show("BORÇ GİRİŞİNİ ONAYLIYOR MUSUNUZ?", "BORÇ GİRİŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    decimal tutar = Convert.ToDecimal(txt_tutar.Text);
                    string isim = txt_isim.Text;
                    string aciklama = txt_aciklama.Text;
                    DateTime date = dtp_tarih.Value;
                    string telNo = msk_telNo.Text;

                    _transactionService.AddDebt(isim, tutar, date, aciklama,telNo);
                    _context.SaveChanges();
                    MessageBox.Show("BAŞARIYLA KAYDEDİLDİ.","BAŞARILI",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
