using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksuHaliEvi
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Turnover> Turnovers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Veritabanı bağlantı bilgilerinizi burada belirtin.
            optionsBuilder.UseSqlServer("Server=DESKTOP-EHV3NLA\\SQLEXPRESS; Database=AksuHaliEvi; User Id=sa;Password=1;");
        }
    }

}
