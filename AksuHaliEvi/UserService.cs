using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasaProgramı
{
    public class UserService
    {
        private readonly MyDbContext _context;


        public UserService(MyDbContext context)
        {
            _context = context;
        }


        public bool AuthenticateUser(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

            return user != null;

        }

        public bool Register(string userName, string password, string email)
        {
            var users = _context.Users.ToList();
            bool varmi = false;
            foreach (var user in users)
            {
                if (userName == user.UserName)
                {
                    MessageBox.Show("Bu kullanıcı adı kullanılmış.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    varmi = true;                  
                    break;
                    
                }
            }

            if (varmi == false)
            {
                var newUser = new User
                {
                    UserName = userName,
                    Password = password,
                    Email = email
                };
                _context.Users.Add(newUser);
                _context.SaveChanges();
                
                MessageBox.Show("Yeni kayıt eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
