using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOf5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.


            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine(b);
            }
            else if (c >= b && c >= a && c >= d && c >= e)
            {
                Console.WriteLine(c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine(d);

            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine(e);
            }
        }
    }
}
