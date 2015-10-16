using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stat
{
    class Stats
    {

        public static double mean(ArrayList array)
        {
            double total = 0, mean = 0;
            // calculate the mean of the data in array
            foreach (double x in array) total += x;
            mean = total / array.Count;
            return mean;
        }

        public static double variance(ArrayList array)
        {
            double max = 0, variance = 0;
            //get max number for the variance
            foreach (double x in array)
            {
                if (max < x)
                {
                    max = x;
                }
            }

            // calculate the variance of array
            foreach (double x in array)
            {
                double difference = max - x;
                difference = difference * difference;
                variance += difference;
            }
            return variance /= (array.Count - 1); //should this be just array.count ?
        }

        public static double stdDev(ArrayList array)
        {
            return Math.Sqrt(variance(array));
        }
    }
}
