using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup and create a company
            List<Employee> employees = CreateEmployees();
            List<Division> divisions = CreateDivisions();
            List<Position> positions = CreatePositions();
            Company company = new Company("Widget Sales", employees, positions, divisions);

            // generate company reports
            company.PrintEmployeeReport();

            Console.WriteLine();

            company.PrintDivisionReport();

            Console.ReadLine();
        }

        /// <summary>
        ///  setup all company employees
        /// </summary>
        static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();

            // administration employees
            employees.Add(new Employee(1342, "David Taubman", PositionID.CEO, DivisionID.Administration));
            employees.Add(new Employee(1345, "Linda Taubman", PositionID.Manager, DivisionID.Administration));
            employees.Add(new Employee(1256, "Peter Lin", PositionID.Clerk, DivisionID.Administration));

            // sales employees
            employees.Add(new Employee(5490, "Alan MacArthur", PositionID.Clerk, DivisionID.Sales));
            employees.Add(new Employee(8601, "Janice Cohen", PositionID.Manager, DivisionID.Sales));
            employees.Add(new Employee(2290, "Mary Copeland", PositionID.Clerk, DivisionID.Sales));
            employees.Add(new Employee(4511, "Mary Sutherland", PositionID.JuniorClerk, DivisionID.Sales));
            employees.Add(new Employee(9079, "Steven Peters", PositionID.Clerk, DivisionID.Sales));

            // marketing employees
            employees.Add(new Employee(5054, "Alan Parkes", PositionID.Clerk, DivisionID.Marketing));
            employees.Add(new Employee(2349, "Alison Davidson", PositionID.Clerk, DivisionID.Marketing));
            employees.Add(new Employee(3760, "Charlie Anderson", PositionID.Manager, DivisionID.Marketing));
            employees.Add(new Employee(4511, "Wendy Chu", PositionID.SeniorClerk, DivisionID.Marketing));

            return employees;
        }

        /// <summary>
        /// set up all positions used by the company
        /// </summary>
        static List<Position> CreatePositions()
        {
            List<Position> positions = new List<Position>();

            positions.Add(new Position(PositionID.CEO, "CEO", 88012.00m));
            positions.Add(new Position(PositionID.Manager, "Manager", 67238.00m));
            positions.Add(new Position(PositionID.SeniorClerk, "Senior Clerk", 49129.00m));
            positions.Add(new Position(PositionID.Clerk, "Clerk", 32956.00m));
            positions.Add(new Position(PositionID.JuniorClerk, "Junior Clerk", 22827.00m));

            return positions;
        }

        /// <summary>
        /// setup the company divisions
        /// </summary>
        static List<Division> CreateDivisions()
        {
            List<Division> divisions = new List<Division>();

            divisions.Add(new Division(DivisionID.Administration, "Administration"));
            divisions.Add(new Division(DivisionID.Marketing, "Marketing"));
            divisions.Add(new Division(DivisionID.Sales, "Sales"));

            return divisions;
        }
    }
}
