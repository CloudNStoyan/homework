using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i] = i * 5);
            }
        }
    }
}
