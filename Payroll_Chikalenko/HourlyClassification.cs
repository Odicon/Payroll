using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class HourlyClassification : PaymentClassification
    {
        private readonly double hourlyRate;

        public HourlyClassification(double hourlyRate)
        {
            this.hourlyRate = hourlyRate;
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
        }

        public override string ToString()
        {
            return String.Format("${0}", hourlyRate);
        }
    }
}
