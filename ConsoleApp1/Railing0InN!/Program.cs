using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railing0InN_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
            //Your program should work well for very big numbers, e.g. N = 100000.
            //On the only input line, you will receive a single integer - the number N
            //Output a single number - the count of trailing zeroes for the N!


            Console.Write("Input: ");
            ulong n = ulong.Parse(Console.ReadLine());
            ulong factorial = 1;
            
            //Explanation
            if (n > 65)
            {
                Console.WriteLine("Explanation: Think why");
            }
            else
            {
                for (ulong i = n; i > 1; i--) //Finding factorial
                {
                    factorial *= i; 
                }
                Console.WriteLine("Explanation: " + factorial);
            }
            if (n < 10)// Finding how many zeros n has at its end.
            {
                Console.WriteLine("Output: " + (n / 4 - 1));
            }
            else
            {
                Console.WriteLine("Output: " + (n / 5));
            }
        }
    }
}
