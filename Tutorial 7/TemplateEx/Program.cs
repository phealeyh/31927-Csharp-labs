using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateEx
{
    class Program
    {
        class c1 : IComparable<c1>
        {
            int x;

            public c1(int i)
            {
                x = i;
            }

            public int X
            {
                get { return x; }
            }

            public int CompareTo(c1 other)
            {
                if (x < other.x) return 1;
                else if (x > other.x) return -1;
                else return 0;
            }

            public override string ToString()
            {
                return "" + x;
            }
        }

        class c2 : IComparable<c2>
        {
            double d;

            public c2(double i)
            {
                d = i;
            }

            public double D
            {
                get { return d; }
            }

            public int CompareTo(c2 other)
            {
                if (d < other.d) return 1;
                else if (d > other.d) return -1;
                else return 0;
            }


            public override string ToString()
            {
                return "" + d;
            }
        }

        static public void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            // use very simple bubble sort to sort array
            int i, j;
            T temp;

            for (i = array.Length - 1; i > 0;  i--)
            {
                for (j = 0; j < i; j++)
                {
                    temp = array[j];
                    if (array[j].CompareTo(array[j + 1]) < 0)
                    {
                        // swap contents of array[j] and array[j+1]
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static public void PrintArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            c1[] array1 = new c1[10];
            c2[] array2 = new c2[10];

            for (int i = 0; i < 10; i++)
            {
                array1[i] = new c1((i * 7) % 10);
                array2[i] = new c2((i * 13) % 10);
            }

            Console.WriteLine("Before sorting");
            PrintArray(array1);
            PrintArray(array2);

            BubbleSort(array1);
            BubbleSort(array2);

            Console.WriteLine("After sorting");
            PrintArray(array1);
            PrintArray(array2);

            Console.ReadLine();
        }
    }
}
