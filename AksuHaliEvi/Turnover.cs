using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksuHaliEvi
{
    public class Turnover
    {
        public int TurnoverID { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public DateTime Date { get; set; }
    }
}
