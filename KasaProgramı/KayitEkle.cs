using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasaProgramı
{
    public partial class KayitEkle : Form
    {
        private readonly MyDbContext myDbContext;
        
        public KayitEkle()
        {
            InitializeComponent();
            myDbContext = new MyDbContext();

        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text != txt_sifre2.Text)
            {
                MessageBox.Show("Şifre Doğrulama Hatalı !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string userName = txt_kullaniciadi.Text;
                string email = txt_email.Text;
                string password = txt_sifre.Text;
                string authority = comboBox1.SelectedItem.ToString();
                UserService userService = new UserService(myDbContext);
                bool deger = userService.Register(userName, password, email, authority);
                if (deger == false)
                {
                    txt_kullaniciadi.Text = "";
                }
                else
                {
                    
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
