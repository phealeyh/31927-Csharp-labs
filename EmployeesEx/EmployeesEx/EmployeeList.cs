using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EmployeesEx
{
    class EmployeeList
    {
        List<Employee> employees;

        public EmployeeList()
        {
            employees = new List<Employee>();
        }

        public void LoadEmployees(string filename)
        {
            StreamReader fin = new StreamReader(filename);
            Employee emp;

            while (!fin.EndOfStream)
            {
                // there are still employees to be loaded
                emp = new Employee();
                emp.LoadEmployee(fin);
                if (EmployeeAlreadyLoaded(emp)) throw new Exception("Duplicate employee in list");
                employees.Add(emp);
            }

            fin.Close();
        }

        public bool EmployeeAlreadyLoaded(Employee employee)
        {
            foreach(Employee emp in employees){
                if (emp.EmployeeNumber == employee.EmployeeNumber) return true;
            }
            return false;
        }

        public void PrintEmployees()
        {
            // prints each employee in the employees list on a seperate line

            foreach (Employee emp in employees)
            {
                emp.PrintEmployee();
                Console.WriteLine();
            }
            

        }

        public void SortEmployees()
        {
            employees.Sort();
        }
    }
}
