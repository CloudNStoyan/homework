using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimalNumSystem
{
    class Program
    {
        static void Convert(string chars)
        {
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
        static void Main(string[] args)
        {
            //Write a program that converts a binary number N to its decimal representation.
            string input = Console.ReadLine();
            Convert(input);
        }
    }
}
