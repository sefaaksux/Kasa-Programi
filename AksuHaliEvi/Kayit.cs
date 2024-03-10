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
    public partial class Kayit : Form
    {
     
        private readonly MyDbContext _myDbContext;
        public Kayit(MyDbContext myDbContext)
        {
            InitializeComponent();
            _myDbContext = myDbContext;
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            if(txt_sifre.Text != txt_sifre2.Text)
            {
                MessageBox.Show("Şifre Doğrulama Hatalı !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                string userName = txt_kullaniciadi.Text;
                string email = txt_email.Text;
                string password = txt_sifre.Text;
                UserService userService = new UserService(_myDbContext);
                bool deger = userService.Register(userName, password, email);
                if(deger == false)
                {
                    txt_kullaniciadi.Text = "";
                }
                else
                {
                Login login = new Login();
                login.Show();
                this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // TextBox'un şifre karakterini kapat
                txt_sifre.PasswordChar = '\0';
                txt_sifre.UseSystemPasswordChar = false;
                txt_sifre2.PasswordChar = '\0';
                txt_sifre2.UseSystemPasswordChar = false;
            }
            else
            {
                // CheckBox işaretli değilse, TextBox'u şifre karakteri ile gizle
                txt_sifre.PasswordChar = '*';
                txt_sifre.UseSystemPasswordChar = true;
                txt_sifre2.PasswordChar = '*';
                txt_sifre2.UseSystemPasswordChar = true;
            }
        }
    }
}
