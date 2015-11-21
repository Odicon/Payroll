using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class HourlyClassification : PaymentClassification
    {
        private readonly double hourlyRate;
        private Hashtable timeCard = new Hashtable();

        public TimeCard GetTimeCard(DateTime date)
        {
            return timeCard[date] as TimeCard;
        }

        public void AddTimeCard(TimeCard card)
        {
            timeCard[card.Date] = card;
        }

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
