using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Chikalenko
{
    public class PayrollDatabase
    {
        private static Hashtable employees = new Hashtable();
        private static Hashtable unionMembers = new Hashtable();

        public static void AddUnionMember(int id, Employee e)
        {
            unionMembers[id] = e;
        }

        public static Employee GetUnionMember(int id)
        {
            return unionMembers[id] as Employee;
        }

        public static void RemoveUnionMember(int memberId)
        {
            unionMembers.Remove(memberId);
        }
 
        public static void AddEmployee(int id, Employee employee)
        {
            employees[id] = employee;
        }

        public static Employee GetEmployee(int id)
        {
            return employees[id] as Employee;
        }

        public static void DeleteEmployee(int empid)
        {
            employees.Remove(empid);
        }
    }
}
