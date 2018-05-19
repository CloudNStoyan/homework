using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryFemaleGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int odd = 0;
            int even = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += int.Parse(input[i] + "");
                }
                else
                {
                    odd += int.Parse(input[i] + "");
                }
            }

            if (even > odd)
            {
                Console.WriteLine($"right {even}");
            } else if (odd > even)
            {
                Console.WriteLine($"left {odd}");
            }
            else if (odd == even)
            {
                Console.WriteLine($"straight {odd}");
            }

        }
    }
}
