using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightmareOnCodeStreet
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine() + "";
            int length = 0;
            int sum = 0;

            for (int i = 1; i < input.Length; i+= 2)
            {
                length++;
                sum += int.Parse(input[i] + "");
            }

            Console.WriteLine($"{length} {sum}");
        }
    }
}
