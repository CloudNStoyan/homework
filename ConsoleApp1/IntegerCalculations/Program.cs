using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class Program
    {
        public static void Calculate(int[] arr)
        {
            int minimum = arr.Min();
            int maximum = arr.Max();
            decimal average = arr.Sum() / arr.Length;
            int sum = arr.Sum();

            Console.WriteLine(minimum);
            Console.WriteLine(maximum);
            Console.WriteLine("{0:F2}",average);
            Console.WriteLine(sum);
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{" + i / 2 + " , " + i / 2 + "} ");
                }
                else
                {
                    Console.Write("{" + (i / 2 + 1) + " , " + i / 2 + "} ");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            /*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable 
             * number of arguments. Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.*/
            int[] arr = {3, 7, 9, 18, 0};
            Calculate(arr);
        }
    }
}
