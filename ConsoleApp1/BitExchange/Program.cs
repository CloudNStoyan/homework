using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).
            //Input
            //On the only input line you will receive the unsigned integer number whose bits you must exchange.
            //Output
            //On the only output line print the value of the integer with the exchanged bits.

            int n = int.Parse(Console.ReadLine());


            string binaryStr = Convert.ToString(n, 2);
            string binaryToStr = binaryStr = binaryStr.PadLeft(32, '0');
            
            StringBuilder strB = new StringBuilder(binaryToStr);

            char nChar = strB[28]; // 3 bit
            char nChar2 = strB[27]; // 4 bit
            char nChar3 = strB[26]; // 5 bit

            char dChar = strB[7]; //24 bit /3 bits
            char dChar2 = strB[6]; //25 bit /4 bits
            char dChar3 = strB[5]; //26 bit /5 bits


            strB[28] = dChar;
            strB[27] = dChar2;
            strB[26] = dChar3;

            strB[7] = nChar;
            strB[6] = nChar2;
            strB[5] = nChar3;

            binaryToStr = strB.ToString();
            int binaryOfInputToInt = Convert.ToInt32(binaryToStr, 2);

            Console.WriteLine("Modified value: {0}", binaryToStr);
            Console.WriteLine("Output: {0}", binaryOfInputToInt);
        }
    }
}
