using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
            int n = int.Parse(Console.ReadLine());
            
            int[] array = new int[n];

            int maxSeq = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (i > 0)
                {
                    if (array[i] == array[i - 1])
                    {
                        maxSeq++;
                    }
                }
            }
            Console.WriteLine(maxSeq);
        }
    }
}
