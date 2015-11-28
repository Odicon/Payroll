using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class Employee
    {
        private readonly int empid;
        private string name;
        private string address;
        private PaymentClassification classification;
        private PaymentSchedule schedule;
        private PaymentMethod method;
        private Affiliation affiliation;

        public Employee(int empid, string name, string address)
        {
            this.empid = empid;
            this.name = name;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int EmpId
        {
            get { return empid; }
        }

        public PaymentClassification Classification
        {
            get { return classification; }
            set { classification = value; }
        }

        public PaymentSchedule Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }

        public PaymentMethod Method
        {
            get { return method; }
            set { method = value; }
        }

        public Affiliation Affiliation
        {
            get { return affiliation; }
            set { affiliation = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Emp#: ").Append(empid).Append(" ");
            sb.Append(name).Append(" ");
            sb.Append(address).Append(" ");
            sb.Append("Paid ").Append(classification).Append(" ");
            sb.Append(schedule);
            sb.Append(" by ").Append(method);
            return sb.ToString();
        }
    }
}
