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

namespace KasaProgramı
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
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 13);
           
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.CadetBlue;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = this.dataGridView1.DefaultCellStyle;

        }

        private void ParaGirisListele_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
                   
            var query = from item in _context.Incomes
                        join mymethot in _context.PaymentMethods on item.MethodID equals mymethot.MethodID
                        select new
                        {
                            TUTAR = item.Amount,
                            AÇIKLAMA = item.Description,
                            ÖDEMEYÖNTEMİ = mymethot.MethodName,
                            TARİH = item.IncomeDate.ToShortDateString()
                        };

            dataGridView1.DataSource = query.ToList();
            
            
            dataGridView1.Columns[0].Width = 110;        
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 150; 

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
                             TUTAR = income.Amount,
                             AÇIKLAMA = income.Description,
                             ÖDEMEYÖNTEMİ =paymentMethod.MethodName,
                             TARİH = income.IncomeDate  
                         }).ToList();


            dataGridView1.DataSource = query;
        }
    }
}
