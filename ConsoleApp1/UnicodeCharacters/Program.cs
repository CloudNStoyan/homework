using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that converts a string to a sequence of C# Unicode character literals.
            string word = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            foreach (char c in word)
            {
                int decimalRepresentation = c;
                result.Append(ConvertToUnicode(decimalRepresentation));
            }

            Console.WriteLine(result.ToString());
        }   

        static string ConvertToUnicode(decimal n)
        {
            string prefix = @"\u00";
            decimal quot = n;
            decimal remainder = n % 16;
            string hexNumber = "";

            while (quot > 0)
            {
                quot = Math.Floor(n / 16);
                remainder = n % 16;
                if (remainder > 9)
                {
                    remainder = remainder + 55;
                    hexNumber += (char)remainder;
                }
                else
                {
                    hexNumber +=  remainder;
                }
                n = quot;
            }
            char[] charArray = hexNumber.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            return prefix + result;
        }
    }
}
