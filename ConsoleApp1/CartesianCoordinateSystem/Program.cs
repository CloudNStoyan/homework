using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CartesianCoordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int xMax = 6;
            int yMax = 5;

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine(1);
                } else if (y < 0)
                {
                    Console.WriteLine(4);
                }
                else
                {
                    Console.WriteLine(x > xMax ? xMax : x);
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine(2);
                } else if (y < 0)
                {
                    Console.WriteLine(3);
                }
                else
                {
                    Console.WriteLine(x > xMax ? xMax : x);
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine(y > yMax ? yMax : y);
                } else if (y < 0)
                {
                    Console.WriteLine(y > yMax ? yMax : y);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
