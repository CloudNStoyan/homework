using System;
using System.Collections.Generic;

namespace IncreasingAbsoluteDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() + "");

            var sequences = new List<string>();

            for (int i = 0; i < n; i++)
            {
                sequences.Add(Console.ReadLine());
            }


            for (int i = 0; i < sequences.Count; i++)
            {
                var line = sequences[i].Split(' ');
                var currentSequence = new List<int>();
                
                for (int j = 0; j < line.Length; j++)
                {
                    if (j + 1 >= line.Length)
                    {
                        break;
                    }

                    if (int.Parse(line[j] + "") > int.Parse(line[j + 1] + ""))
                    {
                        currentSequence.Add(int.Parse(line[j] + "") - int.Parse(line[j + 1] + ""));
                    }
                    else
                    {
                        currentSequence.Add(int.Parse(line[j + 1] + "") - int.Parse(line[j] + ""));
                    }
                }

                Console.WriteLine(IsIncreasingSequence(currentSequence));
            }
        }

        static bool IsIncreasingSequence(List<int> sequence)
        {
            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] - sequence[i - 1] > 1 || sequence[i] < sequence[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
