using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two positive integer numbers N and M and prints how many numbers exist between them such that the reminder of the division by 5 is 0.

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string howMany = "These can:";

            for (int i = start; i < end; i++)
            {
                if (i % 5 == 0)
                {
                    howMany = howMany + " " + i.ToString();
                }
            }
            if (howMany.EndsWith(":"))
            {
                Console.WriteLine("think why" +
                                  "");
            }
            else
            {
                Console.WriteLine(howMany);
            }
        }
    }
}
