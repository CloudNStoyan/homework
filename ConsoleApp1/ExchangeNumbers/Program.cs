using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two double values from the console A and B, stores them in variables and exchanges their values
            //if the first one is greater than the second one. Use an if-statement. As a result print the values of the variables A and B, separated by a space.

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(b + " " + a);
            }
            else
            {
                Console.WriteLine(a + " " + b);
            }
        }
    }
}
