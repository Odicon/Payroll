using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class ChangeUnaffiliatedTransaction : ChangeAffiliationTransaction
    {
        public ChangeUnaffiliatedTransaction(int empId) : base(empId) { }

        protected override Affiliation Affiliation
        {
            get { return new NoAffiliation(); }
        }

        protected override void RecordMembership(Employee e)
        {
            Affiliation affiliation = e.Affiliation;
            if (affiliation is UnionAffiliation)
            {
                UnionAffiliation unionAffiliation = affiliation as UnionAffiliation;
                int memberId = unionAffiliation.MemberId;
                PayrollDatabase.RemoveUnionMember(memberId);
            }
        }
    }
}
