using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            string encoded = Console.ReadLine();
            var decodedWords = ClearQuotes(Console.ReadLine().Split(','));

            int sum = 0;

            var buildWord = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
            {
                buildWord.Append(encoded[i]);
                int index = isThereWord(buildWord.ToString(), decodedWords);
                if (index >= 0)
                {
                    sum += Cost(buildWord.ToString(), decodedWords[index]);
                    buildWord.Clear();
                }
            }

            Console.WriteLine(sum > 0 ? sum : -1);
        }

        static int isThereWord(string word, string[] words)
        {
            var allChars = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                allChars.Add(word[i]);
            }
            allChars.Sort();
            int index = 0;
            foreach (string s in words)
            {
                var wordChars = new List<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    wordChars.Add(s[i]);
                }
                wordChars.Sort();

                
                if (IsEqual(allChars.ToArray(),wordChars.ToArray()))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        static int Cost(string word, string word1)
        {
            int minus = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word1[i])
                {
                    minus++;
                }
            }

            return word.Length - minus;
        }

        static string[] ClearQuotes(string[] strArr)
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i] = strArr[i].Replace('"', ' ').Trim();
            }

            return strArr;
        }

        static bool IsEqual(char[] arr1, char[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
