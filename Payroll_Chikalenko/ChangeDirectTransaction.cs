using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class ChangeDirectTransaction : ChangeMethodTransaction
    {
        public ChangeDirectTransaction(int id) : base(id) { }

        protected override PaymentMethod Method
        {
            get { return new DirectDepositMethod(); }
        }
    }
}
