using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public abstract class AddEmployeeTransaction : Transaction
    {
        private readonly int empid;
        private readonly string name;
        private readonly string address;

        public AddEmployeeTransaction(int empid, string name, string address)
        {
            this.empid = empid;
            this.name = name;
            this.address = address;
        }

        protected abstract PaymentClassification MakeClassification();

        protected abstract PaymentSchedule MakeSchedule();

        public void Execute()
        {
            Employee e = new Employee(empid, name, address);
            PaymentClassification pc = MakeClassification();
            PaymentSchedule ps = MakeSchedule();
            PaymentMethod pm = new HoldMethod();

            e.Classification = pc;
            e.Schedule = ps;
            e.Method = pm;
            PayrollDatabase.AddEmployee(empid, e);
        }

        public override string ToString()
        {
            return String.Format("{0}\tid:{1}\tname:{2}\taddress:{3}", GetType().Name, empid, name, address);
        }
    }
}
