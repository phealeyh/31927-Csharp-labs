using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EmployeesEx
{
    class Employee : IComparable<Employee>
    {
        private string surname;
        private double hourlyRate;
        private int empNumber;

        public Employee() 
        {
            hourlyRate = -1;
            empNumber = -1;
            surname = "abc";
        }
      
        public void setEmployee(string name, double rate, int num) 
        { 
            surname = name;
            hourlyRate = rate;
            empNumber = num;
        }
      
        public string Surname
        {
            get { return surname; }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
        }

        public int EmployeeNumber
        {
            get { return empNumber; }
        }
      
        public void PrintEmployee()
        {
            Console.Write("{0, -10} {1, 4} {2, 6:F2}", surname, empNumber, hourlyRate);
        }
      
        public void LoadEmployee(StreamReader fin) 
        {
            string line;

            surname = fin.ReadLine();

            line = fin.ReadLine();
            if (!Double.TryParse(line, out hourlyRate) || hourlyRate < 0)
            {
                throw new IOException("Invalid hourly rate in employee file");
            }

            line = fin.ReadLine();
            if (!int.TryParse(line, out empNumber) || empNumber < 0)
            {
                throw new IOException("Invalid employee number in employee file");
            }
        }

        public int CompareTo(Employee other)
        {
            if (empNumber < other.empNumber) return -1;
            else if (empNumber == other.empNumber) return 1;
            else return 0;
        }
    }
}
