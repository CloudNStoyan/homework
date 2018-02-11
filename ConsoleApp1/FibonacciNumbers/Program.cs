using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence (at a single 
            //line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

            double n = double.Parse(Console.ReadLine());

            double half = Math.Round((n / 100) * 40);
            double otherHalf = Math.Round((n / 100) * 60);

            for (double i = 0; i < n; i++)
            {
                if (half != 0)
                {
                    {
                        Console.WriteLine(half);
                        Console.WriteLine(otherHalf);
                        half = Math.Round((otherHalf / 100) * 38);
                        otherHalf = Math.Round((otherHalf / 100) * 62);
                    }
                }

            }
        }
    }
}
