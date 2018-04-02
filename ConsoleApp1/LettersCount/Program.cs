using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and prints all different letters in the string along with information how 
            //many times each letter is found.

            char[] letters = Console.ReadLine().ToCharArray();
            List<char> used = new List<char>();

            var dic = new Dictionary<char,int>();

            foreach (char letter in letters)
            {
                if (letter != ' ')
                {
                    if (used.Contains(letter) == false)
                    {
                        used.Add(letter);
                        dic.Add(letter, 1);
                    }
                    else
                    {
                        dic[letter]++;
                    }
                }
            }

            foreach (char c in used)
            {
                Console.WriteLine("| " + c + " , " + dic[c] + " |");
            }
        }
    }
}
