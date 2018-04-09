using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearcingInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find all occurrences of a word within a text and return the indices of the occurrences

            var text = "gg b gg pesho ivan gg";

            var indexs = Occurences(text, "g");

            foreach (int i in indexs)
            {
                Console.WriteLine(i);
            }
        }

        static List<int> Occurences(string str,string word)
        {
            var indexs = new List<int>();


            int index = str.IndexOf(word);

            while (index != -1)
            {
                indexs.Add(index);
                index = str.IndexOf(word, index + word.Length);
            }
            return indexs;
        }
    }
}
