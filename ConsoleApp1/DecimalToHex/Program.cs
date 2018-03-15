using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Convert(decimal n)
        {
            
            decimal quot = n;
            decimal reminder = n % 16;
            string hexNumber = "";

            while (quot > 0)
            {
                quot = Math.Floor(n / 16);
                reminder = n % 16;
                if (reminder > 9)
                {
                    reminder = reminder + 55;
                    hexNumber = hexNumber + (char)reminder;
                }
                else
                {
                    hexNumber = hexNumber + reminder;
                }
                n = quot;
            }
            char[] charArray = hexNumber.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
        static void Main(string[] args)
        {
            //Write a program that converts a decimal number N to its hexadecimal representation.
            int n = int.Parse(Console.ReadLine());
            Convert(n);
        }   
    }
}
