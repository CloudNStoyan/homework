using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds all prime numbers in the range [1 ... N].
            //Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.

            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                list.Add(i);
            }

            for (int j = 2; j <= n; j++)
            {
                for (int i = j; i < list.Count; i++)
                {
                    if (list[i] != j && list[i] % j == 0)
                    {
                        list.RemoveAt(i);
                    }

                }
            }
            Console.WriteLine(list.Max());
        }
    }
}
