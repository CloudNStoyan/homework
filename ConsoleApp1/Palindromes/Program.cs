using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
            string[] text = Console.ReadLine().Split(' ');
            string[] palindroms = Array.FindAll(text, isPalindrom);
            foreach (string palindrom in palindroms)
            {
                Console.WriteLine(palindrom);
            }
        }

        static bool isPalindrom(string word)
        {
            List<char> array = new List<char>();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                array.Add(word[i]);
            }

            string editedWord = new string(array.ToArray());
            if (word == editedWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
