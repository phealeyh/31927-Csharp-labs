using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyEx
{
    class Company
    {
        public readonly string CompanyName;
        public readonly List<Employee> employees;
        public readonly List<Division> divisions;
        public readonly List<Position> positions;

        public Company(string name, List<Employee> e, List<Position> p, List<Division> d)
        {
            CompanyName = name;

            // set up company structure
            employees = e;
            positions = p;
            divisions = d;
        }

        public void PrintEmployeeReport()
        {
            Console.WriteLine(CompanyName + " employee report");

            // create a query 
            var report = from employee in employees
                         join division in divisions
                         on employee.DID equals division.DivID
                         join position in positions
                         on employee.PID equals position.PosID
                         let person = new { employee.Name, division.DivName, position.Title, position.Salary }
                         select person;

            // run the query and print the result
            foreach (var employee in report)
            {
                Console.WriteLine("Employee: {0, -18} {1, -16} {2, -16} {3:c}", employee.Name, employee.DivName, employee.Title, employee.Salary);
            }
        }

        public void PrintDivisionReport()
        {

            //print division report
            Console.WriteLine(CompanyName + " division report");
        }
    }
}
