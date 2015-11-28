using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class UnionAffiliation : Affiliation
    {
        private Hashtable charges = new Hashtable();
        private int memberId;
        private readonly double charge;

        public UnionAffiliation(int memberId, double charge)
        {
            this.memberId = memberId;
            this.charge = charge;
        }

        public UnionAffiliation() : this(-1, 0.0)
        { }

        public ServiceCharge GerServiceCharge(DateTime date)
        {
            return charges[date] as ServiceCharge;
        }

        public void AddServiceCharge(ServiceCharge sc)
        {
            charges[sc.Date] = sc;
        }

        public double Charge
        {
            get { return charge; }
        }

        public int MemberId
        {
            get { return memberId; }
        }
    }
}
