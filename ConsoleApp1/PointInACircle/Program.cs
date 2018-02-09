using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the coordinates of a point x and y and using an expression checks if given point (x, y) is inside a 
            //circle K({0, 0}, 2) - the center has coordinates (0, 0) and the circle has radius 2. The program should then print "yes 
            //DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.
            //In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.
            //Input
            //You will receive exactly two lines, the first containing the x coordinate, the second containing the y coordinate.
            //Output
            //Output a single line in the format described above. The distance should be always printed with 2-digit precision after the floating point.


            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double center_x = 0;
            double center_y = 0;


            double number = Math.Sqrt(Math.Pow(center_x - x, 2) + Math.Pow(center_y - y, 2));

            if (number <= 2)
            {
                Console.WriteLine("true {0}",Math.Round(number,2));
            }
            else
            {
                Console.WriteLine("false {0}",Math.Round(number,2));  
            }
        }
    }
}
