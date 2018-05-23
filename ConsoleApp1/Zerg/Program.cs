using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> getNumber = new Dictionary<string, int>()
            {
                {"Rawr", 0},
                {"Rrrr", 1},
                {"Hsst", 2},
                {"Ssst", 3},
                {"Grrr", 4},
                {"Rarr", 5},
                {"Mrrr", 6},
                {"Psst", 7},
                {"Uaah", 8},
                {"Uaha", 9},
                {"Zzzz", 10},
                {"Bauu", 11},
                {"Djav", 12},
                {"Myau", 13},
                {"Gruh", 14}
            };

            string input = Console.ReadLine();

            var build = new List<int>();
            for (int i = 0; i < input.Length; i += 4)
            {
                string buildedNum = input.Substring(i, 4);

                int number = getNumber[buildedNum];

                build.Add(number);
            }

            int sum = 0;

            build.Reverse();

            for (int i = 0; i < build.Count; i++)
            {
                if (i > 0)
                {
                    sum += build[i] * (int)(Math.Pow(15, i));
                }
                else
                {
                    sum += build[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
