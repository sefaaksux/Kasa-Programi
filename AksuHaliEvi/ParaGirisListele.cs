using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AksuHaliEvi
{
    public partial class ParaGirisListele : Form
    {
        MyDbContext _context;
        public ParaGirisListele()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }

        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
        }

        private void ParaGirisListele_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            var query = from item in _context.Incomes
                        join mymethot in _context.PaymentMethods on item.MethodID equals mymethot.MethodID  
                        select new{
                                           TUTAR = item.Amount,
                                           AÇIKLAMA = item.Description,
                                           ÖDEMEYÖNTEMİ = mymethot.MethodName,
                                           TARİH = item.IncomeDate
                                   };
            dataGridView1.DataSource = query.ToList();





        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime baslangic = monthCalendar1.SelectionStart;
            DateTime bitis = monthCalendar1.SelectionEnd;

            var query = from item in _context.Incomes
                        join mymethod in _context.PaymentMethods on item.MethodID equals mymethod.MethodID
                        where item.IncomeDate >= baslangic && item.IncomeDate <= bitis
                        select new
                        {
                            TUTAR = item.Amount,
                            AÇIKLAMA = item.Description,
                            ÖDEMEYÖNTEMİ = mymethod.MethodName,
                            TARİH = item.IncomeDate
                        };
            dataGridView1.DataSource = query.ToList();

           lbl1.Text = (baslangic.ToShortDateString() +" / "+bitis.ToShortDateString()).ToString();

            decimal toplamTutar = _context.Incomes
            .Where(i => i.IncomeDate >= baslangic && i.IncomeDate <= bitis)
            .Sum(i => i.Amount);

            lbl2.Text = (Convert.ToUInt32( toplamTutar)+" TL").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetFontAndColors();
            var query = from item in _context.Incomes
                        join mymethot in _context.PaymentMethods on item.MethodID equals mymethot.MethodID
                        select new
                        {
                            TUTAR = item.Amount,
                            AÇIKLAMA = item.Description,
                            ÖDEMEYÖNTEMİ = mymethot.MethodName,
                            TARİH = item.IncomeDate
                        };
            dataGridView1.DataSource = query.ToList();
            lbl1.Text = "";
            lbl2.Text = "";
            txt_arama.Text = "";
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_arama.Text.ToLower();

            var query = (from income in _context.Incomes
                         join paymentMethod in _context.PaymentMethods
                         on income.MethodID equals paymentMethod.MethodID
                         where income.Description.ToLower().Contains(aranan)
                         select new
                         {
                             income.Amount,
                             income.Description,
                             paymentMethod.MethodName,
                             income.IncomeDate  
                         }).ToList();


            dataGridView1.DataSource = query;
        }
    }
}
