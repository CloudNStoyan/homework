using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() ?? "0");

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            Console.WriteLine(result);
        }
    }
}