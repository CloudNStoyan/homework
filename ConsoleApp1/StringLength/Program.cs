using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a string of maximum 20 characters.
            //If the length of the string is less than 20, the rest of the characters should be filled with *.

            string input = Console.ReadLine() + "";

            if (input.Length < 20)
            {
                for (int i = input.Length; i < 20; i++)
                {
                    input += "*";
                }
            }

            Console.WriteLine(input);
        }
    }
}
