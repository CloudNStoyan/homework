using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write an expression that calculates rectangle’s area and perimeter by given width and height. The width and height should be read from the console.
            //Input
            //The input will consist of 2 lines:
            //On the first line, you will receive a floating-point number that will represent the width of the rectangle.
            //On the second line, you will receive another floating-point number that will represent the height of the rectangle.
            //Output
            //Output a single line - the rectangle's area and perimeter, separated by a whitespace.
            //Print the area and perimeter values with exactly 2-digits precision after the floating point



            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());

            decimal area = number1 * number2;
            decimal perimeter = (number1 + number2) * 2;

            if (area.ToString().EndsWith("00") || perimeter.ToString().EndsWith("00")) {
                string areaStr = area.ToString();
                string perimeterStr = perimeter.ToString();
                Console.WriteLine(areaStr + " " + perimeterStr);
            }
            else {
                string areaStr = area.ToString() + "0";
                string perimeterStr = perimeter.ToString() + "0";
                Console.WriteLine(areaStr + " " + perimeterStr);
            }

            

        }
    }
}
