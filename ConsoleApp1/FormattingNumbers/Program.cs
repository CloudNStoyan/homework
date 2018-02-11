using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program that reads 3 numbers:
            integer a(0 <= a <= 500)
            floating - point b
            floating - point c
                The program then prints them in 4 virtual columns on the console.Each column should have a width of 10 characters.
            The number a should be printed in hexadecimal, left aligned
            Then the number a should be printed in binary form, padded with zeroes
            The number b should be printed with 2 digits after the decimal point, right aligned
            The number c should be printed with 3 digits after the decimal point, left aligned.
            */

            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            string binaryStr = Convert.ToString(a, 2);
            string binaryToStr = binaryStr = binaryStr.PadLeft(16, '0');

            Console.WriteLine("{0:X}",a);
            Console.WriteLine(binaryToStr);
            Console.WriteLine("{0}.00", b);
            Console.WriteLine("{0}.000",c);
        }
    }
}
