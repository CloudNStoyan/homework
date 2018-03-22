using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceBySideAndAltitude
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write program that calculates the surface of a triangle by given a side and an altitude to it.
            while (true)
            {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine((a * b) / 2);
            }
        }
    }
}
