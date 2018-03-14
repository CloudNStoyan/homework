using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        public static int Factorial(int n)
        {
            int result = n;
            for (int i = n-1; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
        static void Main(string[] args)
        {
            //Write a method that multiplies a number represented as an array of digits by a given integer number. Write a program to calculate N!.
            Console.WriteLine(Factorial(5));
        }
    }
}
