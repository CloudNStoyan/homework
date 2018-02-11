using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - Math.Abs(4 * a * c);

            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.Clear();

            if (0 > d)
            {
                Console.WriteLine("no real roots");
            }
            else if (d == 0)
            {
                x1 = -b * (2 * a);
                Console.WriteLine("{0:f2}", x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                double minX = Math.Min(x1, x2);
                double maxX = Math.Max(x1, x2);

                Console.WriteLine("{0:f2}", minX);
                Console.WriteLine("{0:f2}", maxX);


            }
        }
    }
}
