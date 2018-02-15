using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //In combinatorics, the number of ways to choose N different members out of a group of N different elements (also known as 
            //the number of combinations) is calculated by the following formula: formula For example, there are 2598960 
            //ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.



            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            
            double factorial = n;
            double factorial2 = k;
            double KN = factorial - factorial2;

            for (int i = 1; i < n; i++)
            {
                factorial = factorial * i;
            }
            for (int i = 1; i < k; i++)
            {
                factorial2 = factorial2 * i;
            }
            for (int i = 1; i < KN; i++)
            {
                KN = KN * i;
            }

            Console.WriteLine(factorial / (factorial2 * KN));

        }
    }
}
