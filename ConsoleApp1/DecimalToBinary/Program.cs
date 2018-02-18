using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using loops write a program that converts an integer number to its binary representation.
            //The input is entered as long. The output should be a variable of type string.
            //Do not use the built-in .NET functionality.

            int num = int.Parse(Console.ReadLine());
            int quot;
            string reminder = "";
            while (num >= 1)
            {
                quot = num / 2;
                reminder += (num % 2).ToString();
                num = quot;
            }
            string bin = "";
            for (int i = reminder.Length - 1; i >= 0; i--)
            {
                bin = bin + reminder[i];
            }
            Console.WriteLine(bin);
        }
    }
}
