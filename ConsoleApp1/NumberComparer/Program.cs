using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that gets two numbers from the console and prints the greater of them.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }


        }
    }
}
