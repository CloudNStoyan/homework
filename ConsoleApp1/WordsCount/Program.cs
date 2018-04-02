using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and lists all different words in the string along with information how 
            //many times each word is found.

            string[] text = Console.ReadLine().Split(' ');
            List<string> used = new List<string>();

            var dic = new Dictionary<string, int>();

            foreach (string word in text)
            {
                if (used.Contains(word) == false)
                {
                    used.Add(word);
                    dic.Add(word, 1);
                }
                else
                {
                    dic[word]++;
                }

            }

            foreach (string word in used)
            {
                Console.WriteLine("| " + word + " , " + dic[word] + " |");
            }
        }
    }
}
