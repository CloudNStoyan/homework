using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array lenght: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Looking for: ");
            int x = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int middle = (arr.Length / 2) - 1;
            int indexOfX = -1;
            while (true)
            {
                if (arr[middle] == x)
                {
                    indexOfX = middle;
                    break;
                }

                if (arr[middle] > x)
                {
                    middle = middle / 2;
                }

                if (arr[middle] < x)
                {
                    middle = middle + (middle / 2);
                }


            }

            Console.Clear();
            Console.WriteLine("The index {0} contains the {1} number!", indexOfX, x);
        }
    }
}
