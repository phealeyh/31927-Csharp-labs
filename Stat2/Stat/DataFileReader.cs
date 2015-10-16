using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace Stat
{
    class DataFileReader
    {
        public static ArrayList LoadDataFile(string filepath)
        {
            if (!File.Exists(filepath)) throw new FileNotFoundException("Unable to file specified file", filepath);

            ArrayList array = new ArrayList();
            double value;
            string line;

            // read the data from the file into array
            StreamReader fin = new StreamReader(filepath);
            while (!fin.EndOfStream)
            {
                line = fin.ReadLine();
                if (!double.TryParse(line, out value)) throw new Exception("Invalid double in " + filepath);
                array.Add(value);
            }

            // return the standard deviation
            return array;
        }
    }
}
