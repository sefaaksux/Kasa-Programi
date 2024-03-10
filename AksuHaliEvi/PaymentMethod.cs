using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaProgramı
{
    public class PaymentMethod
    {
        [Key]
        public int MethodID { get; set; }
        public string MethodName { get; set; }

        public List<Income> Incomes { get; set; }
        public List<Expense> Expenses { get; set; }

    }
}
