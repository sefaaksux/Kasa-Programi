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
    public partial class Login : Form
    {
        private readonly UserService _userService;
        public Login()
        {
            InitializeComponent();
            _userService = new UserService(new MyDbContext());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // TextBox'un şifre karakterini kapat
                txt_sifre.PasswordChar = '\0';
                txt_sifre.UseSystemPasswordChar = false;
            }
            else
            {
                // CheckBox işaretli değilse, TextBox'u şifre karakteri ile gizle
                txt_sifre.PasswordChar = '*';
                txt_sifre.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            

            string userName = txt_kullaniciadi.Text;
            string password = txt_sifre.Text;

            

            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("TÜM ALANLARI DOLDURUNUZ !", "HATA");
            }
            else
            {
                var result = _userService.AuthenticateUser(userName, password);
                if (result)
                {
                    anasayfa anasayfa = new anasayfa();
                    anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "HATA");
                }

            }

            

            


        }

        private void lbl_sifreunuttum_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
