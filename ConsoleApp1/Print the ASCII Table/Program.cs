using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find online more information about ASCII (American Standard Code for Information Interchange)
            // and write a program that prints the visible characters of the ASCII table on the console (characters from 33 to 126 including).
            //Note: You may need to use for-loops(learn in Internet how).
            //Output
            //The 94 characters on single line



            string letter = "";
            for (int i = 33; i <= 126; i++)
            {
                letter += (char) i;
                if (i == 126)
                {
                    Console.WriteLine(letter);
                }

            }
        }
    }
}