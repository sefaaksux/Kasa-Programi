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
    public partial class ParaCikisiListele : Form
    {
        MyDbContext _context;
        public ParaCikisiListele()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }

        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 13);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkRed;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = this.dataGridView1.DefaultCellStyle;
        }

        private void ParaCikisiListele_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            

            var query = from item in _context.Expenses
                        join mymethot in _context.PaymentMethods on item.MethodID equals mymethot.MethodID
                        select new 
                        { 
                           TUTAR = item.Amount,
                           AÇIKLAMA =  item.Description,
                           ÖDEMEYÖNTEMİ = mymethot.MethodName,
                           TARİH = item.ExpenseDate.ToShortDateString()
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

            var query = from item in _context.Expenses
                        join mymethot in _context.PaymentMethods on item.MethodID equals mymethot.MethodID
                        where item.ExpenseDate >= baslangic && item.ExpenseDate <= bitis
                        select new
                        {
                            TUTAR = item.Amount,
                            AÇIKLAMA = item.Description,
                            ÖDEMEYÖNTEMİ = mymethot.MethodName,
                            TARİH = item.ExpenseDate
                        };
            dataGridView1.DataSource = query.ToList();

            lbl1.Text = (baslangic.ToShortDateString() + " / " + bitis.ToShortDateString()).ToString();

            decimal toplamTutar = _context.Expenses
            .Where(i => i.ExpenseDate >= baslangic && i.ExpenseDate <= bitis)
            .Sum(i => i.Amount);

            lbl2.Text = (Convert.ToUInt32(toplamTutar) + " TL").ToString();


        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            SetFontAndColors();
            var query = from item in _context.Expenses
                        join mymethot in _context.PaymentMethods on item.MethodID equals mymethot.MethodID
                        select new
                        {
                            TUTAR = item.Amount,
                            AÇIKLAMA = item.Description,
                            ÖDEMEYÖNTEMİ = mymethot.MethodName,
                            TARİH = item.ExpenseDate
                        };
            dataGridView1.DataSource = query.ToList();

            lbl1.Text = "";
            lbl2.Text = "";
            txt_arama.Text = "";
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_arama.Text.ToLower();

            var query = (from Expense in _context.Expenses
                         join paymentMethod in _context.PaymentMethods
                         on Expense.MethodID equals paymentMethod.MethodID
                         where Expense.Description.ToLower().Contains(aranan)
                         select new
                         {
                             Expense.Amount,
                             Expense.Description,
                             paymentMethod.MethodName,
                             Expense.ExpenseDate
                         }).ToList();


            dataGridView1.DataSource = query;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
