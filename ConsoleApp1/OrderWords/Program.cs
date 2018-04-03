using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrderWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
            string[] words = Console.ReadLine().ToLower().Split(' ');
            List<string> capitalizedWords = new List<string>();
            foreach (string word in words)
            {
                
                if (word.Length > 1)
                {
                    char[] temp = Regex.Replace(word, @"\p{P}", "").ToCharArray();
                    temp[0] = Convert.ToChar(temp[0].ToString().ToUpper());
                    capitalizedWords.Add(new string(temp));
                }
            }
            capitalizedWords.Sort();
            foreach (string capitalizedWord in capitalizedWords)
            {
                Console.WriteLine(capitalizedWord);
            }


        }
    }
}
