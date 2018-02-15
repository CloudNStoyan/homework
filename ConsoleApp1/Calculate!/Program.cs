using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, for a given two numbers N and x, calculates the factorial S = 1 + 1!/x + 2!/x2 + … + N!/xN.
            //Use only one loop. Print the result with 5 digits after the decimal point.

            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            int factorial = 1;
            double sum = 1 + 1 / x;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
                double pow = Math.Pow(x, i);
                sum = sum + (factorial / pow);
            }
            Console.WriteLine("{0:F5}", sum);

        }
    }
}
