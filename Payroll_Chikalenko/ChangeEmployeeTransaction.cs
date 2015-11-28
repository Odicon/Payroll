using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public abstract class ChangeEmployeeTransaction : Transaction
    {
        private readonly int empId;

        public ChangeEmployeeTransaction(int empId)
        {
            this.empId = empId;
        }

        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);
            if (e != null)
                Change(e);
            else
                throw new InvalidOperationException("Работник не найден.");
        }

        protected abstract void Change(Employee e);
    }
}
