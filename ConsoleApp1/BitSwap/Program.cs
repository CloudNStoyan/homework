using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program first reads 4 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. 
            //Print the resulting integer on the console.
            //Input
            //On the only four lines of the input you will receive the integers n, p, q and k in this order.
            //Output
            //Output a single value - the value of n after the bit swaps.

            int n = int.Parse(Console.ReadLine()); // Number
            int p = int.Parse(Console.ReadLine()); // Bit
            int q = int.Parse(Console.ReadLine()); // Bit
            int k = int.Parse(Console.ReadLine()); // Bit

            

            string binaryStr = Convert.ToString(n, 2);
            string binaryToStr = binaryStr = binaryStr.PadLeft(32, '0');

            StringBuilder strB = new StringBuilder(binaryToStr);

            char nChar = strB[p-1]; // p bit
            char nChar2 = strB[p+1-1]; // p+1 bit
            char nChar3 = strB[p+k-1-1]; // p+k-1 bit

            char dChar = strB[q-1]; //q bit
            char dChar2 = strB[q+1-1]; //q+1 bit
            char dChar3 = strB[q+k-1-1]; //Q+k-1 bit


            strB[p] = dChar;
            strB[p+1] = dChar2;
            strB[p+k-1] = dChar3;

            strB[q] = nChar;
            strB[q+1] = nChar2;
            strB[q+k+1] = nChar3;

            binaryToStr = strB.ToString();
            int binaryOfInputToInt = Convert.ToInt32(binaryToStr, 2);

            Console.WriteLine("Modified value: {0}", binaryToStr);
            Console.WriteLine("Output: {0}", binaryOfInputToInt);
        }
    }
}
