using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that generates and prints to the console 10 random values in the range [100, 200].
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                int n = rnd.Next(100, 200);
                Console.WriteLine(n);
            }
        }
    }
}
