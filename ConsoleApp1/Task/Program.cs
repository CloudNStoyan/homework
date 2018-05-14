using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static List<int> complexity = new List<int>();
        static List<string> tasks = new List<string>();
        static StringBuilder output = new StringBuilder();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() + "");
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string command = line.Split(' ')[0].Trim();

                switch (command)
                {
                    case "New":
                        int number = int.Parse(line.Split(' ')[1]);
                        string task = GetRestOf(line, number + "");
                        Console.WriteLine(task);
                        Add(number,task);
                        break;
                    case "Solve":
                        Solve();
                        break;
                }
            }

            Console.WriteLine("---------");
            Console.WriteLine(output.ToString().Trim());
        }

        static void Add(int complex, string task)
        {
            complexity.Add(complex);
            tasks.Add(task);
        }

        static void Solve()
        {
            if (complexity.Count < 1)
            {
                output.AppendLine("Rest");
                return;
            }

            int minCompl = complexity.Min();
            int index = complexity.IndexOf(minCompl);


            int isAlone = CheckIfIsOne(index, minCompl);

            if (isAlone == -1)
            {
                output.AppendLine(tasks[index]);
                Delete(index);
            }
            else
            {
                output.AppendLine(tasks[isAlone]);
                Delete(isAlone);
            }

        }


        static int CheckIfIsOne(int index,int min)
        {
            var indexes = new List<int>();
            for (int i = 0; i < complexity.Count; i++)
            {
                if (i != index && complexity[i] == min)
                {
                    indexes.Add(i);
                }
            }

            if (indexes.Count < 1)
            {
                return -1;
            }
            else
            {
                var sortedTasks = new List<string>();
                foreach (int i in indexes)
                {
                    sortedTasks.Add(tasks[i]);
                }

                sortedTasks.Sort();
                return tasks.IndexOf(sortedTasks[0]);
            }
        }

        static string GetRestOf(string text, string word)
        {
            int startIndex = text.IndexOf(word) + 1;
            int length = text.Length - startIndex;
            return text.Substring(startIndex, length).Trim();
        }

        static void Delete(int index)
        {
            tasks.RemoveAt(index);
            complexity.RemoveAt(index);
        }

        static int GetLexicValue(string text)
        {
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                sum += text[i];
            }

            return sum;
        }
    }
}
