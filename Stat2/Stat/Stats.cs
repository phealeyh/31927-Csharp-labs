using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Stat
{
    class Stats
    {
        public static double Mean(ArrayList array)
        {
            if (array.Count == 0) throw new Exception("Must have at least one item to calculate mean");

            double total = 0;

            // calculate the mean of the data in array
            foreach (double x in array) total += x;
            return (total / array.Count);
        }

        public static double Variance(ArrayList array)
        {
            if (array.Count < 2) throw new Exception("Must have at least two items to calculate std dev");

            double difference, variance = 0, mean = Mean(array);

            // calculate the variance of array
            foreach (double x in array)
            {
                difference = x - mean;
                // square difference
                difference *= difference;
                variance += difference;
            }
            
            return (variance / (array.Count - 1));
        }

        public static double StdDev(ArrayList array)
        {
            return Math.Sqrt(Variance(array));
        }
    }
}
