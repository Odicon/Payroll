using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class ChangeCommissionedTransaction : ChangeClassificationTransaction
    {
        private readonly double salary;
        private readonly double commissionRate;

        public ChangeCommissionedTransaction(int id, double salary, double commissionRate)
            : base(id)
        {
            this.salary = salary;
            this.commissionRate = commissionRate;
        }

        protected override PaymentClassification Classification
        {
            get { return new CommissionedClassification(salary, commissionRate); }
        }

        protected override PaymentSchedule Schedule
        {
            get { return new BiweeklySchedule(); }
        }
    }
}
