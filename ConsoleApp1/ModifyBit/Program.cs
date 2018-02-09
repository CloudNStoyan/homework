using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are given an integer number N (read from the console), a bit value v (read from the console as well) (v = 0 or 1) and a 
            //Position P (read from the console). Write a sequence of operators (a few lines of C# code) that modifies N to hold the value v
            //at the position P from the binary representation of N while preserving all other bits in N. Print the resulting number on the console
            //Input
            //The input will consist of exactly 3 lines containing the following:
            //First line - the integer number N.
            //Second line - the position P.
            //Third line - the bit value v.
            //Output
            //Output a single line containing the value of the number N with the modified bit.


            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            string binaryStr = Convert.ToString(n, 2);
            string binaryToStr = binaryStr = binaryStr.PadLeft(32, '0');
            char nChar = '0';
            if (v == 1)
            {
                nChar = '1';
            }

            int nCalc = 31 - p;
            StringBuilder strB = new StringBuilder(binaryToStr);
            strB[nCalc] = nChar;
            binaryToStr = strB.ToString();
            int binaryOfInputToInt = Convert.ToInt32(binaryToStr, 2);
            
            Console.WriteLine("Modified value: {0}",binaryToStr);
            Console.WriteLine("Output: {0}",binaryOfInputToInt);
        }
    }
}
