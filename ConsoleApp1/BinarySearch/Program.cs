using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the index of given element X in a sorted listay of N integers by using the Binary search algorithm.
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int num = int.Parse(Console.ReadLine());

            int low = 0, height = arr.Length - 1;

            while (true)
            {
                int middle = low + ((height - low) / 2);

                int candidate = arr[middle];

                if (candidate == num)
                {
                    Console.WriteLine(middle);
                    break;
                }

                if (candidate > num)
                {
                    height = middle;
                }

                if (candidate < num)
                {
                    low = middle;
                }
            }
        }
    }
}
