using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            var job = new Dictionary<string, int>();
            List<string> names = new List<string>();
            List<string> ranks = new List<string>();
            List<string> output = new List<string>();

            int jobsNumber = int.Parse(Console.ReadLine() + "");
            for (int i = 0; i < jobsNumber; i++)
            {
                string[] line = Console.ReadLine().Split('-');
                string key = line[0].Trim();
                int value = int.Parse(line[1]);

                job.Add(key,value);
            }

            int namesNumber = int.Parse(Console.ReadLine() + "");
            for (int i = 0; i < namesNumber; i++)
            {
                string[] line = Console.ReadLine().Split('-');
                string name = line[0].Trim();
                string rank = line[1].Trim();

                names.Add(name);
                ranks.Add(rank);
            }

            var orderedRanks = ranks;
            orderedRanks.Sort();

            Console.WriteLine("------------------------------");
            int lower = 100000;
            int oldLower = 0;
            var ids = new Dictionary<int,int>();


            while (output.Count != names.Count)
            {
                bool throughAll = false;
                int index = 0;
                for (int i = 0; i < names.Count; i++)
                {
                    if (job[ranks[i]] < lower && !ids.ContainsKey(job[ranks[i]]))
                    {
                        lower = job[ranks[i]];
                        index = i;
                    }

                    
                }

                Console.WriteLine(oldLower + " > " + lower);
                if (!ids.ContainsKey(lower))
                {
                    ids.Add(lower, 0);
                }
                output.Add(names[index]);
                oldLower = lower;
            }


            foreach (string s in output)
            {
                Console.WriteLine(s);
            }


        }
    }
}
