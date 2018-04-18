using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine() + ""));
            }
            int howManyLeft = int.Parse(Console.ReadLine() + "");

            for (int i = numbers.Count; numbers.Count != howManyLeft; i++)
            {
                numbers.Add(numbers[i - 1] + numbers[i - 2] + numbers[i - 3]);
            }

            Console.WriteLine(numbers[numbers.Count - 1]);
        }
    }
}
