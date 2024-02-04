using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksuHaliEvi
{
    public class TransactionService
    {
        private readonly MyDbContext _context;

        public TransactionService(MyDbContext context)
        {
            _context = context;
        }

        public void AddIncome(decimal amount, DateTime incomeDate, string description, int methodId)
        {
            var income = new Income
            {
                Amount = amount,
                IncomeDate = incomeDate,
                Description = description,        
                MethodID = methodId
            };

            _context.Incomes.Add(income);
            _context.SaveChanges();

            var turnover = _context.Turnovers.FirstOrDefault();

            turnover.TotalIncome += amount;
            _context.SaveChanges();

        }

        public void AddExpense(decimal amount, DateTime expenseDate, string description, int methodId)
        {
            var expense = new Expense
            {
                Amount = amount,
                ExpenseDate = expenseDate,
                Description = description,
                MethodID = methodId
            };

            _context.Expenses.Add(expense);
            _context.SaveChanges();

            var turnover = _context.Turnovers.FirstOrDefault();

            turnover.TotalExpense += amount;
            _context.SaveChanges();
        }
    }

}
