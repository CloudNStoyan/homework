using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace RelevanceIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int howManyLines = int.Parse(Console.ReadLine() + "");
            var map = new Dictionary<int, string>();

            string[] sentences = new string[howManyLines];

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = Console.ReadLine();
            }

            for (int i = 0; i < sentences.Length; i++)
            {
                map.Add(TimesUsed(word,sentences[i]),sentences[i]);
            }
            Console.Clear();
            PrintSortedDic(map,word);

        }

        static int TimesUsed(string word, string sentence)
        {
            return Regex.Matches(sentence, word).Count;
        }

        static void PrintSortedDic(Dictionary<int, string> map,string word)
        {
            var sortedDict = from entry in map orderby entry.Key descending select entry;
            foreach (KeyValuePair<int, string> pair in sortedDict)
            {
                Console.WriteLine(pair.Value.Replace(word,word.ToUpper()));
            }
        }
    }
}
