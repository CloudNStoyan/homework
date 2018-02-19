using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            long quot = num;
            long reminder = num % 16;
            string hexNumber = "";

            while (quot > 0)
            {
                quot = num / 16;
                reminder = num % 16;
                if (reminder > 9)
                {
                    reminder = reminder + 55;
                    hexNumber = hexNumber + (char)reminder;
                }
                else
                {
                    hexNumber = hexNumber + reminder;
                }
                num = quot;
            }
            char[] charArray = hexNumber.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string (charArray));
        }   
    }
}
