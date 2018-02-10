using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 5 integer numbers from the console and prints their sum.

            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());

            Console.WriteLine(number + number2 + number3 + number4 + number5);
        }
    }
}
