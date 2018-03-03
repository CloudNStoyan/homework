using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
            //Print the minimal number of elements that need to be removed in order for the array to become sorted.

            string numbers = Console.ReadLine();
            var array = Array.ConvertAll(numbers.Split(' '), int.Parse);
            int subset = 1;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    subset += 1;
                }
            }
            Console.WriteLine(array.Length - subset);
        }
    }
}
