using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number and calculates and prints its square root.
            //If the number is invalid or negative, print Invalid number.
            //In all cases finally print Good bye. Use try-catch-finally block.

            try
            {
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}",Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
