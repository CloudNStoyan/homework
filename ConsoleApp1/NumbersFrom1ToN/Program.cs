using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, n], each on a single line.

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
