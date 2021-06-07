using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> newPersons = new List<Employee>();
            string tools = Console.ReadLine();
            EmployeeInElectricDepartament person = new EmployeeInElectricDepartament();
            person.Name = "Kolio";
            person.Salary = 200.15;
            person.NeededTools.Add(tools);
            newPersons.Add(person);
        }
    }
}
