using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Employee
    {
        public Employee(string name , double salary)
        {
            Name = name;
            Salary = salary;
        }
        public Employee()
        {

        }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
