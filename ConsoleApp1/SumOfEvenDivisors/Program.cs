using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfEvenDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine() + "");
            int to = int.Parse(Console.ReadLine() + "");

            var evenDivisors = new List<int>();

            for (int i = from; i < to + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    if (i % j == 0 && j % 2 == 0)
                    {
                        evenDivisors.Add(j);
                    }
                }
            }

            Console.WriteLine(evenDivisors.Sum());
        }
    }
}
