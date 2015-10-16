using System;
using System.Text;
using System.IO;
using System.Collections;


namespace Stat
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = DataFileReader.LoadDataFile(args[0]);
            double sdv = Stats.stdDev(array);
            Console.WriteLine("Standard deviation of array = " + sdv);
        }
    }
}
