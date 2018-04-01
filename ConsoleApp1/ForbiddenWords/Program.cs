using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that 
            //replaces the forbidden words with asterisks.

            string[] forbiddenWords = Console.ReadLine().Split(' ');
            string text = Console.ReadLine();

            foreach (string badWord in forbiddenWords)
            {
               text = text.Replace(badWord, AddStars(badWord));
            }

            Console.WriteLine(text);
        }

        static string AddStars(string word)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                result.Append('*');
            }

            return result.ToString();
        }
    }
}
