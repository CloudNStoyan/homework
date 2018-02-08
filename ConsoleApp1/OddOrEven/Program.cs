using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads an integer from the console, uses an expression to check if given integer is odd or even, and 
            //prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.

            //Input
            //On the single input line you will receive an integer number.

            //Output
            //Output a single line - if the number is even, output even, followed by a whitespace and the value of the number. 
            //Otherwise, print odd, again followed by a whitespace and the number's value. See the sample tests.

            double number = double.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even {0}",number);
            }
            else
            {
                Console.WriteLine("Odd {0}",number);
            }
        }
    }
}
