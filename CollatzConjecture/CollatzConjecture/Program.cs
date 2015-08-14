using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{

    class Program
    {
        static void Main(string[] args)
        {
            //keep getting integer that is greater than 1
            long number = readNumber();
            checkNumber(ref number); //pass by reference
        }

        private static void checkNumber(ref long number)
        {
            long initialNumber = number;
            long largestNumber = number;
            long numberGeneration = 0;
            while (number != 1)
            {
                Console.WriteLine(numberGeneration);
                numberGeneration++;
                setLargestNumber(ref largestNumber, number);
                if (number % 2 != 0) //is odd
                {
                    number = (number * 3) + 1;
                }
                else
                {
                    number = number / 2;
                }
            }
            Console.WriteLine("The Number is {0} reduced to 1 in {1} generations", initialNumber, numberGeneration);
            Console.WriteLine("The largest value in the sequence was {0}", largestNumber);

        }

        private static void setLargestNumber(ref long largestNumber, long number)
        {
            if (largestNumber < number) largestNumber = number;
        }
        
        private static long readNumber()
        {
            Console.WriteLine("Enter a value that is greater than 1");
            while (true) 
            {
                long number = Convert.ToInt64(Console.ReadLine());
                if (number > 1) return number;
                else
                {
                    Console.WriteLine("Enter a value that is greater than 1");
                }
            }
        }

    }
}
