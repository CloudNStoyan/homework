using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h. The three values should be read from 
            //the console in the order shown below. All three value will be floating-point numbers.
            //Input
            //The input will consist of exactly 3 lines:
            //The side a on the first line.
            //The side b on the second line.
            //The height h on the third line.


            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = ((b + a) / 2) * h;

            if (a.ToString().Contains(',') || b.ToString().Contains(',') || h.ToString().Contains(','))
            {
                Console.WriteLine(area);
            }
            else
            {
                Console.WriteLine(area.ToString() + ",0000000");
            }

        }
    }
}
