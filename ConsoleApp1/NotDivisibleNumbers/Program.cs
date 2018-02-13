using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisibleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a positive integer N and prints
            //all the numbers from 1 to N not divisible by 3 or 7, on a single line, separated by a space.

            int input = int.Parse(Console.ReadLine());
            string numbers = "";

            for (int i = 1; i < input; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    numbers += " " + i;
                }
            }
            Console.WriteLine(numbers
                );
        }
    }
}
