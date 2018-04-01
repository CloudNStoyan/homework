using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word 
            //and translates it by using the dictionary.

            string word = Console.ReadLine();

            var dic = new Dictionary<string,string>
            {
                {".NET", "platform for applications from Microsoft"},
                {"CLR", "managed execution environment for .NET"},
                {"namespace", "hierarchical organization of classes"}
            };

            if (dic.ContainsKey(word))
            {
                Console.WriteLine(dic[word]);
            }
            else
            {
                Console.WriteLine("There is no description about {0}",word);
            }
        }
    }
}
