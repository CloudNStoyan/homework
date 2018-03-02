using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that sorts an array of integers using the Merge sort algorithm.
            string numbers = Console.ReadLine();
            var array = Array.ConvertAll(numbers.Split(' '), int.Parse);
            int split = (array.Length - 1) / 2;
            int j = split, temp = 0;
            bool isNotFinded = true;

            while (isNotFinded)
            {
                for (int i = 0; i < array.Length - 1; i += 2)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                    else
                    {
                        isNotFinded = false;
                    }
                }
            }
            foreach (int i in array)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
