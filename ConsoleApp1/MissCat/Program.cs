using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine() + "");
            
            var times = new Dictionary<int,int>();
            var unique = new List<int>();
            int[] votes = new int[lines];

            for (int i = 0; i < votes.Length; i++)
            {
                votes[i] = int.Parse(Console.ReadLine() + "");
                if (!unique.Contains(votes[i]))
                {
                    unique.Add(votes[i]);
                }
                if (times.ContainsKey(votes[i]))
                {
                    times[votes[i]]++;
                }
                else
                {
                    times.Add(votes[i],1);
                }
            }

            Console.WriteLine(FindBiggest(times,unique));

        }


        static int FindBiggest(Dictionary<int, int> dic, List<int> unique)
        {
            int bestValue = 0, bestKey = 0;

            foreach (int i in unique)
            {
                if (dic[i] > bestValue)
                {
                    bestValue = dic[i];
                    bestKey = i;
                }
            }
            

            return bestKey;
        }
    }
}
