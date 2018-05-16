using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaximalPath
{
    class Program
    {
        
        static List<int> parent = new List<int>();
        static List<int> nodes = new List<int>();
        private static int length = 0;
        private static int bestLength = 0;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() + "");
            for (int i = 0; i < n - 1; i++)
            {
                string line = Console.ReadLine() + "";
                int p1 = GetNumber(line.Split(new [] { "<-" }, StringSplitOptions.None)[0]);
                int p2 = GetNumber(line.Split(new [] { "<-" }, StringSplitOptions.None)[1]);

                nodes.Add(p1);
                parent.Add(p2); 
            }


            for (int i = 0; i < parent.Count; i++)
            {
                if (length > bestLength)
                {
                    bestLength = length;
                }
                length = 0;
                SequenceLength(i);
            }


            Console.WriteLine(bestLength);
        }

        static void SequenceLength(int index)
        {
            if (FindIndex(index) != -1)
            {
                SequenceLength(nodes[FindIndex(index)]);
                length++;
            }
        }

        static int FindIndex(int num)
        {
            for (int i = 0; i < parent.Count; i++)
            {
                if (parent[i] == num)
                {
                    return i;
                }
            }

            return -1;
        }

        static int GetNumber(string str)
        {
            return int.Parse(Regex.Match(str, @"\d+").Value);
        }
    }
}
