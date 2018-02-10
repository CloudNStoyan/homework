using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and formatted with 2 digits after the decimal point.
            //Input
            //On the only line of the input you will receive the radius of the circle - r
            //Output
            //You should print one line only: the perimeter and the area of the circle, separated by a whitespace, and with 2 digits precision

            decimal p = 3.14m;
            decimal r = decimal.Parse(Console.ReadLine());

            //area pi x r^2
            //perimetar 2pi x r

            Console.WriteLine("Perimetar :" + (p * 2) * r);
            Console.WriteLine("Area :" + p * (r * r));


        }
    }
}
