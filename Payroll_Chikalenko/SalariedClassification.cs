using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class SalariedClassification : PaymentClassification
    {
        private readonly double salary;

        public SalariedClassification(double salary)
        {
            this.salary = salary;
        }

        public double Salary
        {
            get { return salary; }
        }

        public override string ToString()
        {
            return String.Format("${0}", salary);
        }
    }
}
