using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a sequence of N real numbers and returns the minimal,
            //the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = arr.Min();
            double average = arr.Average();
            int max = arr.Max();
            int sum = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Min={0:F2}",min);
            Console.WriteLine("Max={0:F2}", max);
            Console.WriteLine("Sum={0:F2}", sum);
            Console.WriteLine("Avg={0:F2}", average);
        }
    }
}
