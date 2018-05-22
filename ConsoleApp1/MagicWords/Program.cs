using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() + "");

            var words = new string[n];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < n - 1; i++)
            {
                words = Reorder(words);
            }

            Print(words);

            var outputBuild = new StringBuilder();

            for (int i = 0; i < MaxLength(words); i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].Length >= i)
                    {
                        outputBuild.Append(words[j][i]);
                    }
                }
            }

            Console.WriteLine(outputBuild);
        }

        static string[] Reorder(string[] arr)
        {
            var reordered = new List<string>();
            reordered.Add(arr[arr.Length - 1]);
            for (int i = 0; i < arr.Length; i++)
            {
                reordered.Add(arr[i]);
            }

            return reordered.ToArray();
        }

        static int MaxLength(string[] arr)
        {
            int bestLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > bestLength)
                {
                    bestLength = arr[i].Length;
                }
            }

            return bestLength;
        }

        static void Print(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "|");
            }
        }
}
}
