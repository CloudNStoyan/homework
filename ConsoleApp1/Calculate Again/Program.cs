using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N! / K! for given N and K.

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double factorial = n;
            double factorial2 = k;
         
            for (int i = 1; i < n; i++)
            {
                factorial = factorial * i;
            }
            for (int i = 1; i < k; i++)
            {
                factorial2 = factorial2 * i;
            }
            Console.WriteLine(factorial/factorial2);




        }
    }
}
