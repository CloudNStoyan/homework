using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class Program
    {
        static void Main(string[] args)
        {

            //The gravitational field of the Moon is approximately 17% of that on the Earth.
            //Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
            //The weight W should be read from the console.

            //Input
            //The input will consist of a single line containing a single floating-point number - the weight W.
            //Output
            //Output a single floating-point value - how much a man with the weight W on Earth will weigh on the Moon. Output all 
            //values with exactly 3-digit precision after the floating point.

            double number = double.Parse(Console.ReadLine());
            double result = number / 100 * 17;
            Console.WriteLine(Math.Round(result,3));
        }
    }
}
