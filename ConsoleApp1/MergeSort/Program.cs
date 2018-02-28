using System;
using System.Collections.Generic;
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
            int n = int.Parse(Console.ReadLine());
            int[] startArr = new int[n];
            int[] manyArr = new int[n];
            int[] firstSort = new int[n / 2];
            int[] secondSort = new int [firstSort.Length / 2];

            for (int i = 0; i < startArr.Length; i++)
            {
                startArr[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < firstSort.Length - 1; i+=2)
            {
                if (startArr[i + 1] > startArr[i])
                {
                    
                }
                else
                {
                    firstSort[i + 1] = startArr[i + 1];
                    firstSort[i] = startArr[i];
                }
            }
            for (int i = 0; i < secondSort.Length - 1; i+= 2)
            {
                if (firstSort[i + 1] > firstSort[i])
                {
                    secondSort[i + 1] = firstSort[i + 1];
                    secondSort[i] = firstSort[i];
                } else
                {
                    secondSort[i] = firstSort[i];
                    secondSort[i + 1] = firstSort[i + 1];
                }
            }
            Console.Clear();
            foreach (int i in secondSort)
            {
                Console.WriteLine(i);
            }
            //dosent work not finished send help :C
        }
    }
}
