using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaProgramı
{
    public class Income
    {
        public int IncomeID { get; set; }
        public decimal Amount { get; set; }
        public DateTime IncomeDate { get; set; }
        public string Description { get; set; }
        public int MethodID { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
    }
}
