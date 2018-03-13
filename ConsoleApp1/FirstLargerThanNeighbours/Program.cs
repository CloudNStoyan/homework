using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
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
            //Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.
            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (largeThanNeighbours(i, arr))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
