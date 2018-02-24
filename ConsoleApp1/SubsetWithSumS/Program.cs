using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetWithSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S.
            Console.Write("S: ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            if (array.Sum() < s)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
