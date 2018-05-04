using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            var job = new Dictionary<string, int>();
            var output = new Dictionary<string,int>();


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

                output.Add(name,job[rank]);
            }

            var sortedDict = output.OrderByDescending(r => r.Value)
                .ThenBy(r => r.Key.Split(' ')[1]).ThenBy(r => r.Key.Split(' ')[0]);
            Console.Clear();

            foreach (var pair in sortedDict)
            {
                Console.WriteLine(pair.Key);
            }
        }
    }
}
