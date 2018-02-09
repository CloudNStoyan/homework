using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.
            //Input
            //On the first line you will receive the number P. On the second line you will receive the number N.
            //Output
            //Output a single value - the value of the N-th bit in P.

            int p = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string binaryStr = Convert.ToString(p, 2);
            string binaryToStr = binaryStr = binaryStr.PadLeft(32, '0');

            int nCalc = 32 - n;
            char result = binaryToStr[nCalc];
            Console.WriteLine(result);
        }
    }
}
