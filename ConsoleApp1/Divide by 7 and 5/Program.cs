using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that does the following:
            //Reads an integer number from the console.
            //Stores in a variable if the number can be divided by 7 and 5 without remainder.
            //Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. Otherwise prints "false 
            //NUMBER". In place of NUMBER print the value of the input number.

            //Input
            //The input will consist of a single integer value.
            //Output
            //The output must always follow the format specified in the description. See the sample tests.


            int input = int.Parse(Console.ReadLine());

            if (input % 7 == 0 && input % 5 == 0)
            {
                Console.WriteLine("True {0}", input);
            } else
            {
                Console.WriteLine("False {0}", input);
            }
           
        }
    }
}
