using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the most frequent number in an array of N elements.

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int count = 1;
            int tempCount;
            int frequentNumber = array[0];
            int tempNumber = 0;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                tempNumber = array[i];
                tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (tempNumber == array[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("{0}({1} times)",frequentNumber,count);
        }
    }
}
