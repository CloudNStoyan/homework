using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBitsOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;

            int result = (num << 1);
            if (result == 8)
            {
                Console.WriteLine(result);
            }

            int result1 = (num >> 1);
            if (result1 == 2)
            {
                Console.WriteLine(result1);
            }

            int pos = 5;
            int number = 35;
            int mask = 32;
            int numberAndMask = number & mask;

            if (numberAndMask > 0)
            {
                Console.WriteLine("For {0} bit at position {1} is 1", number, pos);
            }
            else
            {
                Console.WriteLine("For {0} bit at position {1} is 0", number, pos);
            }
           

        }
    }
}
