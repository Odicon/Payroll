using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class ChangeAddressTransaction : ChangeEmployeeTransaction
    {
        private readonly string newAddress;

        public ChangeAddressTransaction(int id, string newAddress) : base(id)
        {
            this.newAddress = newAddress;
        }

        protected override void Change(Employee e)
        {
            e.Address = newAddress;
        }
    }
}
