using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyEx
{
    enum DivisionID
    {
        Administration,
        Sales,
        Marketing
    }

    class Division
    {
        public readonly DivisionID DivID;
        public readonly string DivName;

        public Division(DivisionID id, string name)
        {
            DivID = id;
            DivName = name;
        }
    }
}
