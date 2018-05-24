using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine() + "");
            }

            int max = (int)numbers.Max();
            int min = (int)numbers.Min();
            double average = numbers.Sum() / 3;

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F2}",average);
        }
    }
}
