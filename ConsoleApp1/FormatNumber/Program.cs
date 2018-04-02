using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific 
            //notation. Format the output aligned right in 15 symbols.

            int number = int.Parse(Console.ReadLine() + "");


            Console.WriteLine("Decimal: {0,15:D}",number);
            Console.WriteLine("Hexadecimal: {0,15:X}",number);
            Console.WriteLine("Percentage: {0,15:p}",number);
            Console.WriteLine("Scientific Notation: {0,15:E}",number);
        }
    }
}
