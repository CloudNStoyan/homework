using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class Program
    {
        static bool largeThanNeighbours(int index, int[] array)
        {
            if (index + 1 < array.Length && index - 1 >= 0)
            {
                if (array[index] > array[index + 1] && array[index] > array[index - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (index - 1 < 0)
                {
                    if (array[index] > array[index + 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (array[index] > array[index - 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            
        }
        static void Main(string[] args)
        {
            //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
            //Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();
            int howMany = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (largeThanNeighbours(i, arr))
                {
                    howMany++;
                }
            }
            Console.WriteLine(howMany);

        }
    }
}
