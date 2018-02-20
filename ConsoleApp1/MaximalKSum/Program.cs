using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < k; i++)
            {
                sum += array.Max();
                array[array.ToList().IndexOf(array.Max())] = 0;
            }
            Console.WriteLine(sum);
        }
    }
}
