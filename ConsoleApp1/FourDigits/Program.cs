using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            //1 Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
            //2 Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
            //3 Puts the last digit in the first position: dabc (in our example 1201) and prints the result.
            //4 Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.
            //Input
            //The input will consist of a single four-digit integer number on a single line.
            //Output
            //Output the result of each action on a separate line, in the same order as they are explained above:
            //meaning the sum comes on the first line, the reversed number on the second, and so on.


            int number = int.Parse(Console.ReadLine());
            string str = number.ToString();
            char a = str[str.Length - 4];
            char b = str[str.Length - 3];
            char c = str[str.Length - 2];
            char d = str[str.Length - 1];

            int aN = (int) Char.GetNumericValue(a);
            int bN = (int) Char.GetNumericValue(b);
            int cN = (int) Char.GetNumericValue(c);
            int dN = (int) Char.GetNumericValue(d);

            int sum = aN + bN + cN + dN;
            string reverse = d.ToString() + c.ToString() + b.ToString() + a.ToString(); //dcba
            string lastToFirst = d.ToString() + a.ToString() + b.ToString() + c.ToString();//dabc
            string exchange = a.ToString() + c.ToString() + b.ToString() + d.ToString(); //acbd
            Console.WriteLine(sum);
            Console.WriteLine(reverse);
            Console.WriteLine(lastToFirst);
            Console.WriteLine(exchange);
            




        }
    }
}
