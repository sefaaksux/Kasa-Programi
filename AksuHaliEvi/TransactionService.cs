using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasaProgramı
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
            

        }

        public bool DownDebt(DataGridView dataGrid,decimal tutar)
        {
            DataGridViewRow product = dataGrid.SelectedRows[0];
            int secilenID =(int)product.Cells["ID"].Value;

            var myProduct = _context.Debts.FirstOrDefault(x => x.DebtID == secilenID);

            if (myProduct != null)
            { 
                if(tutar > myProduct.Amount)
                {
                    MessageBox.Show("Borçtan daha yüksek bir rakam girdiniz !");
                   return false;
                }
                else
                {
                    myProduct.Amount -= tutar;

                    if(myProduct.Amount <= 0)
                    {
                        _context.Debts.Remove(myProduct);
                        MessageBox.Show("BORÇ SIFIRLANDI, KAYIT SİLİNDİ.");
                    }


                    return true;
                }                        
            }
            return false;
        }

        public void DeleteDebt(DataGridView dataGrid)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow product = dataGrid.SelectedRows[0];
                if (product.Cells["ID"].Value != null)
                {
                    int secilenID = (int)product.Cells["ID"].Value;

                    var silinecek = _context.Debts.FirstOrDefault(x => x.DebtID == secilenID);

                    _context.Debts.Remove(silinecek);

                    _context.SaveChanges();


                }
            }
        }

        public void UpdateDebt(DataGridView dataGrid, string name, decimal amount, DateTime date, string description, string phone)
        {
            
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow product = dataGrid.SelectedRows[0];
                if (product.Cells["ID"].Value != null)
                {
                    int secilenID = (int)product.Cells["ID"].Value;

                    var myProduct = _context.Debts.FirstOrDefault(x => x.DebtID == secilenID);

                    if (myProduct != null)
                    {
                        myProduct.Amount = amount;
                        myProduct.Name = name;
                        myProduct.Description = description;
                        myProduct.Phone = phone;
                        myProduct.Date = date;

                        _context.SaveChanges(); // Değişiklikleri veritabanına kaydet
                    }
                    else
                    {
                        MessageBox.Show("Seçilen borç bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen satırın bir ID değeri yok.");
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek bir satır seçilmedi.");
            }

        }

        public void AddDebt(string name, decimal amount, DateTime date, string description,string phone)
        {
            var Debt = new Debt
            {
                Name = name,
                Amount = amount,
                Date = date,
                Description = description,
                Phone = phone            
            };

            _context.Debts.Add(Debt);        
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
           

        }

        
    }

}
