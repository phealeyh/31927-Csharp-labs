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
            try
            {
                if (args.Length != 1) throw new ArgumentException("Must have exactly 1 argument for file to be read");

                ArrayList array = DataFileReader.LoadDataFile(args[0]);
                double sdv = Stats.StdDev(array);

                Console.WriteLine("Standard deviation of array = " + sdv);
            }
            catch (FileNotFoundException fnfEx)
            {
                Console.WriteLine(fnfEx.Message + " - " + fnfEx.FileName);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stat program failed with the following error");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
