using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonExmaples()
        {
            //var person = new Person();
            //person.FirstName = "Nadia";
            //person.ToString();

            var customer = new Customer(true, "Nadia", "Belghozlane", "123456789", "nbelghoz@gmail.com");
            customer.ToString();
            customer.FirstName = "Lawrence";
            customer.IsPremium = true;

            var employee = new Employee();
            employee.FirstName = "Luke";
            employee.HireDate = DateTime.Today;

            var hourlyEmployee = new HourlyEmployee();

            List<Person> people = new List<Person>();
            people.Add(customer);
            people.Add(employee);
            people.Add(hourlyEmployee);

        }
    }
}
