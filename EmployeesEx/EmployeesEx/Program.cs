using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Count() != 1) throw new ArgumentException("Syntax : EmployeesEx employeefile");

                EmployeeList myEmployees = new EmployeeList();

                myEmployees.LoadEmployees(args[0]);
                myEmployees.PrintEmployees();
                myEmployees.SortEmployees();
                Console.WriteLine();
                myEmployees.PrintEmployees();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Program failed with the following error\n");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
