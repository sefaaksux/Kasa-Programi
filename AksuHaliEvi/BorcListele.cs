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
    public partial class BorcListele : Form
    {
        private readonly MyDbContext _context;
        public BorcListele()
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

        private void BorcListele_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            kayitlariGetir();
            
        }
        public void kayitlariGetir()
        {
            var query = from item in _context.Debts
                        select new
                        {
                            İSİM = item.Name,
                            BORÇ = item.Amount,
                            AÇIKLAMA = item.Description,
                            TELEFON = item.Phone,
                            TARİH = item.Date
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void txt_aranan_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_aranan.Text.ToLower();

            var query = from item in _context.Debts
                        where item.Name.ToLower().Contains(aranan)
                        select new
                        {
                            İSİM = item.Name,
                            BORÇ = item.Amount,
                            AÇIKLAMA = item.Description,
                            TARİH = item.Date
                        };
            dataGridView1.DataSource = query.ToList();

            


        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_aranan.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
