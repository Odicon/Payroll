using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class ServiceCharge
    {
        private readonly DateTime date;
        private readonly double charge;

        public ServiceCharge(DateTime date, double charge)
        {
            this.date = date;
            this.charge = charge;
        }

        public DateTime Date
        {
            get { return date; }
        }

        public double Charge
        {
            get { return charge; }
        }
    }
}
