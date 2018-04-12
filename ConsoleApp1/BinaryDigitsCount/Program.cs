using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int binary = int.Parse(Console.ReadLine() + "");
            int length = int.Parse(Console.ReadLine() + "");

            int[] results = new int[length];

            for (int i = 0; i < length; i++)
            {
                uint number = uint.Parse(Console.ReadLine() + "");
                int count = 0;
                while (number >= 1)
                {
                    if (number % 2 == binary)
                    {
                        count++;
                    }
                    number /= 2;
                }

                results[i] = count;
            }

            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
