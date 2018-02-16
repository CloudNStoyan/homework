using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops.

            int n = int.Parse(Console.ReadLine());

            int coll = 0;

            for (int i = 0; i < n; i++)
            {
                coll = i;
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(((n - n + j) + coll) + " ");
                   
                }
                Console.WriteLine(" ");
            }
        }
    }
}

