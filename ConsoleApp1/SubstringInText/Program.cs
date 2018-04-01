using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

            string word = Console.ReadLine() + "".ToLower();
            string text = Console.ReadLine() + "".ToLower();
            int index = 0, count = 0;
            while (true)
            {
                index = text.IndexOf(word, index + word.Length);
                if (index < 0)
                {
                    break;
                }
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
