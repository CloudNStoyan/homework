using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all sentences containing given word.

            string word = " " + Console.ReadLine() + " ";
            string text = Console.ReadLine();

            string[] array = text.Split('.').ToArray();

            foreach (string s in array)
            {
                if (s.Contains(word))
                {
                    Console.WriteLine(s + ".");
                }
            }
        }
    }
}
