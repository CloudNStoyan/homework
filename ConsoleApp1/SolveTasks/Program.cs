using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that can solve these tasks:
             * Reverses the digits of a number
             * Calculates the average of a sequence of integers
             * Solves a linear equation a * x + b = 0
             */
            int[] arr = {1, 1, 1, 1, 2, 2, 2, 3, 5, 5, 5, 6, 1, 1, 2, 3, 3};

            Console.WriteLine(Task.Reverse(321));
            Console.WriteLine(Task.AverageSequence(arr));
            Console.WriteLine(Task.LinearEquation(2,1));
        }
    }
}
