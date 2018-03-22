using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByThreeSides
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write program that calculates the surface of a triangle by given its three sides.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;

            double area = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            Console.WriteLine("{0:F2}",area);
        }
    }
}
