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

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            var query = from item in _context.Turnovers
                        select new
                        {
                            ToplamGiris = item.TotalIncome,
                            ToplamCikis = item.TotalExpense
                        };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
