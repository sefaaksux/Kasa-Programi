using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksuHaliEvi
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Description { get; set; }
        public int MethodID { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
    }
}
