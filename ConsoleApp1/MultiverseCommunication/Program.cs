using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseCommunication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> getNumber = new Dictionary<string, int>()
            {
                {"CHU", 0},
                {"TEL", 1},
                {"OFT", 2},
                {"IVA", 3},
                {"EMY", 4},
                {"VNB", 5},
                {"POQ", 6},
                {"ERI", 7},
                {"CAD", 8},
                {"K-A", 9},
                {"IIA", 10},
                {"YLO", 11},
                {"PLA", 12}
            };

            string input = Console.ReadLine();

            var build = new List<int>();
            for (int i = 0; i < input.Length; i+= 3)
            {
                string buildedNum = input.Substring(i, 3);

                int number = getNumber[buildedNum];
                
                build.Add(number);
            }

            int sum = 0;

            build.Reverse();

            for (int i = 0; i < build.Count; i++)
            {
                if (i > 0)
                {
                    sum += build[i] * (int) (Math.Pow(13, i));
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
