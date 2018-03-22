using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class Program
    {

        static double toRadians(double degs)
        {
            return Math.PI * degs / 180;
        }
        static void Main(string[] args)
        {
            //Write program that calculates the surface of a triangle by given two sides and an angle between them.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double sinC = Math.Sin(toRadians(double.Parse(Console.ReadLine())));

            double area = a * b * sinC / 2;
            Console.WriteLine("{0:F2}",area);
        }
    }
}
