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
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
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
                           TARİH = item.ExpenseDate
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
