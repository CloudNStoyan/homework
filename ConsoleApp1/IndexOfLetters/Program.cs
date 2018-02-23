using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that creates an array containing all letters from the alphabet (a-z). Read a word from the console and print the index of each of its letters in the array.
            char[] letters = new char[25];
            int j = 0;
            for (int i = 97; i < 122; i++)
            {
                letters[j] = (char) i;
                j++;
            }
            string input = Console.ReadLine();
            char[] inputArray = input.ToLower().ToCharArray();
            foreach (char element in inputArray)
            {
                var index = Array.FindIndex(letters, x => x == element);
                Console.WriteLine(index);
            }
        }
    }
}
