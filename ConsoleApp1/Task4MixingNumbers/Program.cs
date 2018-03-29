using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4MixingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have the following operations defined for two-digit numbers:
            //Mixing: mixing ab and cd produces b * c
            //Subtracting: I believe you know how to subtract numbers :)
            //You have a sequence of N two-digit numbers. Your task is to mix and subtract each pair of adjacent numbers.

            string[] numbers = (Console.ReadLine() + "").Split(' ').ToArray();
            string firstLine = "";
            string secondLine = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + 1 >= numbers.Length)
                {
                    break;
                }
                firstLine += int.Parse(numbers[i][1].ToString()) * int.Parse(numbers[i + 1][0].ToString()) + " ";
                secondLine += Math.Abs(int.Parse(numbers[i]) - int.Parse(numbers[i + 1])) + " ";
            }
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
        }
    }
}
