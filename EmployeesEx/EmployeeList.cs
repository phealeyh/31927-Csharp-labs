using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EmployeesEx
{
    class EmployeeList
    {
        private List<Employee> employees;

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
                employees.Add(emp);
            }

            fin.Close();
        }

        public void PrintEmployees()
        {
            // prints each employee in the employees list on a seperate line
            

        }

        public void SortEmployees()
        {
            employees.Sort();
        }
    }
}
