using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AksuHaliEvi
{
    public class TransactionService
    {
        private readonly MyDbContext _context;

        public TransactionService(MyDbContext context)
        {
            _context = context;
        }

        public void DeleteExpense(DataGridView datagrid)
        {
            DataGridViewRow satir = datagrid.SelectedRows[0];
            int secilenID = (int)satir.Cells["ID"].Value;

            var kayit = _context.Expenses.FirstOrDefault(x => x.ExpenseID == secilenID);

            _context.Expenses.Remove(kayit);
            _context.SaveChanges();
        }

        public void DeleteIncome(DataGridView datagrid)
        {
            DataGridViewRow satir = datagrid.SelectedRows[0];
            int secilenID = (int)satir.Cells["ID"].Value;

            var kayit = _context.Incomes.FirstOrDefault(x => x.IncomeID == secilenID);

            _context.Incomes.Remove(kayit);
            _context.SaveChanges();
        }

        public void UpdateIncome(DataGridView dataGrid, decimal amount, DateTime incomeDate, string description, int methodId)
        {
            DataGridViewRow product = dataGrid.SelectedRows[0];
            int secilenID = (int)product.Cells["ID"].Value;

            var myProduct = _context.Incomes.FirstOrDefault(x => x.IncomeID == secilenID);

            decimal tutar = Convert.ToDecimal(amount);
            string aciklama = description;
            int odemeYontemi = methodId;
            DateTime date = incomeDate;

            if (myProduct != null)
            {
                myProduct.Amount = tutar;
                myProduct.Description = aciklama;
                myProduct.MethodID = odemeYontemi;
                myProduct.IncomeDate = date;
            }

            _context.SaveChanges();
            
        }

        public void UpdateExpense(DataGridView dataGrid, decimal amount, DateTime incomeDate, string description, int methodId)
        {
            DataGridViewRow product = dataGrid.SelectedRows[0];
            int secilenID = (int)product.Cells["ID"].Value;

            var myProduct = _context.Expenses.FirstOrDefault(x => x.ExpenseID == secilenID);

            decimal tutar = Convert.ToDecimal(amount);
            string aciklama = description;
            int odemeYontemi = methodId;
            DateTime date = incomeDate;

            if (myProduct != null)
            {
                myProduct.Amount = tutar;
                myProduct.Description = aciklama;
                myProduct.MethodID = odemeYontemi;
                myProduct.ExpenseDate = date;
            }

            _context.SaveChanges();

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

            _context.SaveChanges();
        }
    }

}
