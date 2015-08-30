using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace Stat
{
    class DataFileReader
    {
        public static ArrayList LoadDataFile(String filePath)
        {
            string line;
            double value = 0;
            ArrayList array = new ArrayList();
            StreamReader fin = new StreamReader(filePath);
            line = fin.ReadLine();
            value = double.Parse(line);
            while (!fin.EndOfStream)
            {
                array.Add(value);
            }

            return array;
        }


    }
}
