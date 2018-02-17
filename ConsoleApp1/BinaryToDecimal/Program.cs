using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using loops write a program that converts a binary integer number to its decimal form.
            //The input is entered as string. The output should be a variable of type long.
            //Do not use the built-in .NET functionality.

            string input = "1010101010101011"; //Console.ReadLine();

            //  4   8    16   32
            //1000 0000 1000 0000
            var chars = input.ToArray();

            int result = 0;

            for (var i = 0; i < chars.Length; i++)
            {
                result *= 2;

                if (chars[i] == '1')
                {
                    result += 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}
