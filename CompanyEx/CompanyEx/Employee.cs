using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyEx
{
    class Employee
    {
        public readonly int ID;
        public readonly string Name;
        public readonly PositionID PID;
        public readonly DivisionID DID;

        public Employee(int id, string name, PositionID pid, DivisionID did)
        {
            ID = id;
            Name = name;
            PID = pid;
            DID = did;
        }
    }
}
