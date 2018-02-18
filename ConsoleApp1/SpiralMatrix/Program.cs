using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and prints a matrix holding the 
            //numbers from 1 to N*N in the form of square spiral like in the examples below.


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
