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
    public partial class DuzenleParaGiris : Form
    {
       
        private readonly MyDbContext _context;
        private readonly TransactionService _transactionService;
        public DuzenleParaGiris()
        {
            InitializeComponent();
            _context = new MyDbContext();
            _transactionService = new TransactionService(_context);
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_tutar.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_aciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmb_odemeYontemi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dtp_tarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
        }

        private void DuzenleParaGiris_Load(object sender, EventArgs e)
        {
            verileriGetir();
        }
        private void verileriGetir()
        {
            SetFontAndColors();
            var query = from item in _context.Incomes
                        join mymethot in _context.PaymentMethods on item.MethodID equals mymethot.MethodID
                        select new
                        {
                            ID = item.IncomeID,
                            TUTAR = item.Amount,
                            AÇIKLAMA = item.Description,
                            ÖDEMEYÖNTEMİ = mymethot.MethodName,
                            TARİH = item.IncomeDate
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            decimal tutar = Convert.ToDecimal(txt_tutar.Text);
            string aciklama = txt_aciklama.Text;
            int odemeYontemi = cmb_odemeYontemi.SelectedIndex;
            DateTime date = dtp_tarih.Value;

            if(string.IsNullOrEmpty(aciklama) || string.IsNullOrEmpty(tutar.ToString()))
            {
                MessageBox.Show("LÜTFEN ALANLARI DOLDURUNUZ !");
            }
            else
            {
                if(odemeYontemi == 0)
                {
                    MessageBox.Show("LÜTFEN GEÇERLİ BİR ÖDEME YÖNTEMİ SEÇİNİZ!","GEÇERSİZ ÖDEME",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult cevap = MessageBox.Show("GÜNCELLEMEK İSTİYOR MUSUNUZ ?", "GÜNCELLEME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        _transactionService.UpdateIncome(dataGridView1, tutar, date, aciklama, odemeYontemi);
                        verileriGetir();
                        txt_tutar.Text = "";
                        txt_aciklama.Text = "";
                        cmb_odemeYontemi.SelectedIndex = 0;
                    }
                }

                             
            }         
        }

        

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                _transactionService.DeleteIncome(dataGridView1);
                verileriGetir();
                txt_tutar.Text = "";
                txt_aciklama.Text = "";
                cmb_odemeYontemi.SelectedIndex = 0;
            }
            
            
            
        }
    }
}
