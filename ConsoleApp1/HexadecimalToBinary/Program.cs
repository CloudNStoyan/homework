using System;
using System.Collections.Generic;
using System.Linq;

namespace HexadecimalToBinary
{
    class Program
    {
        static void Convert(string input)
        {
            var map = new Dictionary<string, string>
            {
                {"0", "0000"},
                {"1", "0001"},
                {"2", "0010"},
                {"3", "0011"},
                {"4", "0100"},
                {"5", "0101"},
                {"6", "0110"},
                {"7", "0111"},
                {"8", "1000"},
                {"9", "1001"},
                {"A", "1010"},
                {"B", "1011"},
                {"C", "1100"},
                {"D", "1101"},
                {"E", "1110"},
                {"F", "1111"},
            };

            string output = string.Join("", input.Select(c => map[c.ToString()])).TrimStart('0');

            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            //Write a program to convert hexadecimal numbers to binary numbers (directly).
            while (true)
            {
                string hexNumber = Console.ReadLine();
                Convert(hexNumber);
            }
        }
    }
}