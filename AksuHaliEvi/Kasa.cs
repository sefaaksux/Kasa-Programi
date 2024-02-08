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
    public partial class Kasa : Form
    {

        private readonly MyDbContext _context;
        public Kasa()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 16);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = this.dataGridView1.DefaultCellStyle;
        }
        public class TotalSummary
        {
            public decimal ToplamGiris { get; set; }
            public decimal ToplamCikis { get; set; }
            public decimal Fark { get; set; }
        }
        private void Kasa_Load(object sender, EventArgs e)
        {
             SetFontAndColors();
           
            var query = new TotalSummary
            {
                
                ToplamGiris = _context.Incomes.Sum(x => x.Amount),
                ToplamCikis = _context.Expenses.Sum(x => x.Amount),
                Fark = Math.Abs(_context.Incomes.Sum(x => x.Amount) - _context.Expenses.Sum(x => x.Amount))
            };

            List<TotalSummary> resultList = new List<TotalSummary> { query };

            dataGridView1.DataSource = resultList;

        }
    }
}
