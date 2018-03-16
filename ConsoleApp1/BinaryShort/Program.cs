using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).

            short num = short.Parse(Console.ReadLine());
            int quot;
            string reminder = "";
            while (num >= 1)
            {
                quot = num / 2;
                reminder += (num % 2).ToString();
                num = short.Parse(quot.ToString());
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
