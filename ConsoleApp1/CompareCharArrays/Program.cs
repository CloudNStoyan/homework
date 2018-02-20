using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that compares two char arrays lexicographically (letter by letter).
            string oneStr = Console.ReadLine();
            string twoStr = Console.ReadLine();

            int result = string.Compare(oneStr, twoStr);

            if (result == 0)
            {
                Console.WriteLine("=");
            }

            if (result < 0)
            {
                Console.WriteLine("<");
            }

            if (result > 0)
            {
                Console.WriteLine(">");
            }
        }
    }
}
