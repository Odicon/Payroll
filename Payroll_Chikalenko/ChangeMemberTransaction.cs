using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class ChangeMemberTransaction : ChangeAffiliationTransaction
    {
        private readonly int memberId;
        private readonly double charge;

        public ChangeMemberTransaction(int empId, int memberId, double charge) : base(empId)
        {
            this.memberId = memberId;
            this.charge = charge;
        }
        protected override Affiliation Affiliation
        {
            get { return new UnionAffiliation(memberId, charge); }
        }

        protected override void RecordMembership(Employee e)
        {
            PayrollDatabase.AddUnionMember(memberId, e);
        }
    }
}
