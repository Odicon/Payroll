﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll_Chikalenko;
using System.Text;

namespace PayrollTest_Chikalenko
{
    [TestClass]
    public class PayrollTest_Chikalenko
    {
        [TestMethod]
        public void TestEmployee()
        {
            int empId = 1;
            Employee e = new Employee(empId, "Bob", "Home");
            Assert.AreEqual("Bob", e.Name);
            Assert.AreEqual("Home", e.Address);
            Assert.AreEqual(empId, e.EmpId);
        }

        [TestMethod]
        public void TestEmployeeToString()
        {
            int empId = 1;
            Employee e = new Employee(empId, "Bob", "Home");

            StringBuilder sb = new StringBuilder();
            sb.Append("Emp#: ").Append(empId).Append(" ");
            sb.Append("Bob").Append(" ");
            sb.Append("Home").Append(" ");
            sb.Append("Paid ").Append(e.Classification).Append(" ");
            sb.Append(e.Schedule);
            sb.Append(" by ").Append(e.Method);

            Assert.AreEqual(e.ToString(), sb.ToString());
        }

        [TestMethod]
        public void TestAddSalariedEmployee()
        {
            int empId = 1;
            AddSalariedEmployee t = new AddSalariedEmployee(empId, "Bob", "Home", 1000.00);
            t.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.AreEqual("Bob", e.Name);
            PaymentClassification pc = e.Classification;
            Assert.IsTrue(pc is SalariedClassification);
            SalariedClassification sc = pc as SalariedClassification;
            Assert.AreEqual(1000.00, sc.Salary, .001);
            PaymentSchedule ps = e.Schedule;
            Assert.IsTrue(ps is MonthlySchedule);
            PaymentMethod pm = e.Method;
            Assert.IsTrue(pm is HoldMethod);
        }
    }
}
