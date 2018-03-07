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
            Console.Write("Input: ");
            string numbers = Console.ReadLine();
            var array = Array.ConvertAll(numbers.Split(' '), int.Parse);
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            list.Sort();
            int temp;
            while (true)
            {
                if (array.SequenceEqual(list))
                {
                    break;
                }
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    } else if (array.SequenceEqual(list))
                    {
                        break;
                    }
                }
            }
            Console.Write("Output: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
