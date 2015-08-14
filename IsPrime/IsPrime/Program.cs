using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer");
            string line = Console.ReadLine();

            int number = 0;
            if (!IsPositiveNumber(line, out number))
            {
                Console.WriteLine("Invalid positive integer argument");
            }
            else
            {
                if (IsPrimeNumber(number))
                    Console.WriteLine("{0} is prime", number);
                else
                    Console.WriteLine("{0} is not prime", number);
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            int max = (int)Math.Sqrt(number);
            bool isPrime = true;

            for (int i = 2; i <= max; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        private static bool IsPositiveNumber(string line, out int number)
        {
            return Int32.TryParse(line, out number) || number < 0;
        }
    }
}
