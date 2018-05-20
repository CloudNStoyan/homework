using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine() + "");

            int mitko = 0, vladko = 0;

            for (int i = 0; i < rounds; i++)
            {
                string input = Console.ReadLine();
                input = input.Replace("0","");
                if (input.Length % 2 == 0)
                {
                    mitko += GetBeers(input.Substring(0, input.Length / 2));
                    vladko += GetBeers(input.Substring(input.Length / 2, input.Length / 2));
                }
                else
                {
                    mitko += GetBeers(input.Substring(0, (int)Math.Ceiling((double)input.Length / 2)));
                    vladko += GetBeers(input.Substring(input.Length / 2,(int) Math.Ceiling((double) input.Length / 2)));
                }
            }

            if (mitko != vladko)
            {
                Console.WriteLine(mitko > vladko ? $"M {mitko}" : $"V {vladko}");
            }
            else
            {
                Console.WriteLine($"No {vladko + mitko}");
            }
        }

        static int GetBeers(string input)
        {
            int sum = 0;
            foreach (char c in input)
            {
                sum += Convert.ToInt32(c + "");
            }

            return sum;
        }

    }
}
