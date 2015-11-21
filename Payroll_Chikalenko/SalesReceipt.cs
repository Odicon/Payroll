using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class SalesReceipt
    {
        private readonly DateTime date;
        private readonly int amount;

        public SalesReceipt(DateTime date, int amount)
        {
            this.date = date;
            this.amount = amount;
        }

        public int Amount
        {
            get { return amount; }
        }

        public DateTime Date
        {
            get { return date; }
        }
    }
}
