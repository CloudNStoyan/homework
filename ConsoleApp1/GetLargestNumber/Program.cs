using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int bigger = GetMax.Number(array[0], array[1]);
            if (bigger > array[2])
            {
                Console.WriteLine(bigger);
            }
            else
            {
                Console.WriteLine(array[2]);
            }
        }
    }
}
