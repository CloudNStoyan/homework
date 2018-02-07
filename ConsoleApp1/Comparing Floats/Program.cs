using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.

            //Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating - point arithmetic.
            //Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

            //Input
            //On the first line you will receive the first floating-point number
            //    On the second line you will receive the second floating - point number
            //Hint: Use double.Parse(Console.ReadLine()) to read input
            //Output
            //Print true if the numbers are equal or false if they are not

            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());

            Boolean equal = Math.Abs(number1 - number2) < 0.000001;

            Console.WriteLine(equal);
        }
    }
}
