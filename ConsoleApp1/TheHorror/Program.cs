using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHorror
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = 0, howMany = 0;

            for (int i = 0; i < input.Length; i+= 2)
            {
                sum += int.Parse(input[i] + "");
                howMany++;
            }

            Console.WriteLine($"{howMany} {sum}");
        }
    }
}
