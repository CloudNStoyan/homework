using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two integer arrays of size N from the console and compares them element by element.

            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            if (array1.Sum().Equals(array2.Sum()))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
    }
    }
}
