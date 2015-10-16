using System;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational a, b;

            a = new Rational(2, -4);
            b = new Rational(4, 2);

            Console.WriteLine("Printing a");
            Console.WriteLine("Rational number is " + a.ToString());
            Console.WriteLine();

            Console.WriteLine("Printing b");
            Console.WriteLine("Rational number is " + b.ToString());
            Console.WriteLine();

            Console.WriteLine("Adding a & b");
            Console.WriteLine("Rational number is " + (a + b).ToString());
            Console.WriteLine();

            Console.WriteLine("Subtracting b from a");
            Console.WriteLine("Rational number is " + (a - b).ToString());
            Console.WriteLine();

            Console.WriteLine("Multiplying a & b");
            Console.WriteLine("Rational number is " + (a * b).ToString());
            Console.WriteLine();

            Console.WriteLine("Dividing a by b");
            Console.WriteLine("Rational number is " + (a / b).ToString());

            Console.ReadLine();
        }
    }
}
