using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksuHaliEvi
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





    }
}
