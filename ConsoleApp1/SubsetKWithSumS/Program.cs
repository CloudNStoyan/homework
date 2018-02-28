using System;
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
            //We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S.
            Console.Write("How many elements K: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("How many numbers N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("What sum S: ");
            int s = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int j = 0;
            while (j < array.Length)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[j] + array[i] + array[i + 1] == s && array[j] != array[i] && array[j] != array[i+1])
                    {
                        Console.WriteLine(array[j] + " " + array[i] + " " + array[i+1]);
                    }
                }
                j++;
            }
        }
    }
}
