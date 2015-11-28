using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class ChangeNameTransaction : ChangeEmployeeTransaction
    {
        private readonly string newName;

        public ChangeNameTransaction(int id, string newName) : base(id)
        {
            this.newName = newName;
        }

        protected override void Change(Employee e)
        {
            e.Name = newName;
        }
    }
}
