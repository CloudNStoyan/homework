using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class Program
    {
        public static void sort(int[] array, string order)
        {
            int temp = 0;
            int[] tempArr = new int[array.Length];
            if (order == "ascending")
            {
                Console.WriteLine("Ascending");
                for (int i = checkRest(array.Length,array); i < array.Length; i++)
                {
                    if (array.Min() >= 2000)
                    {
                        break;
                    }
                    int index = array.ToList().IndexOf(array.Min());
                    tempArr[i] = array.Min();
                    array[index] = 2000;
                }
            } else if (order == "descending")
            {
                Console.WriteLine("Descending");
                for (int i = checkRest(array.Length, array); i < array.Length; i++)
                {
                    if (array.Max() <= 1)
                    {
                        break;
                    }
                    int index = array.ToList().IndexOf(array.Max());
                    tempArr[i] = array.Max();
                    array[index] = -1;
                }
            }
            else if (order != "ascending" && order != "descending")
            {
                Console.WriteLine("We don't have that order option!");
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = tempArr[i];
            }
        }
        public static int checkRest(int index, int[] arr)
        {
            int result = 0;
            for (int i = index; i < arr.Length; i++)
            {
                result++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Write a method that returns the maximal element in a portion of array of integers starting at given index.
            //Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.
            int[] arr = {7, 2, 5, 1, 3};

            sort(arr,"descending");
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
