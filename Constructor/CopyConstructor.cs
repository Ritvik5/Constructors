using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Employee
    {
        private string name;
        private int age;
        public Employee(Employee emp)   // declaring Copy constructor.
        {
            name = emp.name;
            age = emp.age;
        }

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Details
        {
            get
            {
                return "\nThe name of Employee is " + name + " and age is " + age.ToString();
            }
        }
    }
}
