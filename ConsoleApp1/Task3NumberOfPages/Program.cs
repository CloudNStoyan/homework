using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3NumberOfPages
{
    class Program
    {
        static void Main(string[] args)
        {
            //A book has N pages, numbered from 1 to N (1, 2, 3, ... N - 1, N).
            //The total number of digits in the page numbers is D.
            //How many pages does the book have?
            //In other words: Write a program to find the number N.

            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            for (int page = 1; digits > 0; page++)
            {
                pages++;
                if (page < 10)
                {
                    digits -= 1;
                } else if (page < 100)
                {
                    digits -= 2;
                } else if (page < 1000)
                {
                    digits -= 3;
                } else if (page < 10000)
                {
                    digits -= 4;
                } else if (page < 100000)
                {
                    digits -= 5;
                } else if (page < 1000000)
                {
                    digits -= 6;
                }
            }
            Console.WriteLine(pages);
        }
    }
}
