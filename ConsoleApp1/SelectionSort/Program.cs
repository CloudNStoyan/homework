using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting an array means to arrange its elements in increasing order.
            //Write a program to sort an array. Use the Selection sort algorithm: 
            //Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

            int rangeOfArray = int.Parse(Console.ReadLine());

            int[] rawArray = new int[rangeOfArray];
            int[] sortedArray = new int[rangeOfArray];

            for (int i = 0; i < rawArray.Length; i++)
            {
                rawArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                sortedArray[i] = rawArray.Min();
                rawArray[rawArray.ToList().IndexOf(rawArray.Min())] = 2000;
                Console.WriteLine(sortedArray[i]);
            }
        }
    }
}
