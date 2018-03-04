using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetKWithSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
            // Find in the array a subset of K elements that have sum S or indicate about its absence.
            int[] array = {2, 1, 2, 4, 3, 5, 2, 6}; // 1 2 5 6
            int k = 4;
            int sum = 14;
            int result = 0;
            int range;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (k + i > array.Length - 1)
                {
                    range = k;
                }
                else
                {
                    range = k + i;
                }
                if (result == sum)
                {
                    break;
                }
                for (int j = i; j < range; j++)
                {
                    result += array[j];
                    if (result > sum)
                    {
                        result = 0;
                        break;
                    }
                    else if (result == sum)
                    {
                        break;
                    }
                    else if (j == (k + i) - 1)
                    {
                        result = 0;
                    }
                }
            }
            Console.Clear();
            if (result == sum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
