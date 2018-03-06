using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationsOfSet
{
    class Program
    {
        private static IEnumerable<string> FindPermutations(string set)
        {
            var output = new List<string>();
            switch (set.Length)
            {
                case 1:
                    output.Add(set);
                    break;
                default:
                    output.AddRange(from c in set let tail = set.Remove(set.IndexOf(c), 1) from tailPerms in FindPermutations(tail) select c + tailPerms);
                    break;
            }
            return output;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = "";
            int factorial = n;
            for (int i = n - 1; i > 1; i--)
            {
                factorial *= i;
            }
            string[] array = new string[factorial];
            for (int i = 1; i < n+1; i++)
            {
                input += i;
            }
            Console.Clear();
            int l = 0;
            foreach (var stringCombination in FindPermutations(input))
            {
                array[l] = "| ";
                for (int i = 0; i < stringCombination.Length; i++)
                {
                    if (i != stringCombination.Length - 1)
                    {
                        array[l] += stringCombination[i] + " , ";
                    }
                    else
                    {
                        array[l] += stringCombination[i] + " ";
                    }
                }
                array[l] += "|";
                Console.WriteLine(array[l]);
                l++;
            }
        }
    }
}
