using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyEx
{
    enum PositionID
    {
        CEO,
        Manager,
        SeniorClerk,
        Clerk,
        JuniorClerk
    }

    class Position
    {
        public readonly PositionID PosID;
        public readonly string Title;
        public readonly decimal Salary;

        public Position(PositionID id, string title, decimal salary)
        {
            PosID = id;
            Title = title;
            Salary = salary;
        }
    }
}
