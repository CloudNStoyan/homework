using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() + "");

            int widthTop = n;
            int widthBot = 2 * n;
            int height = n + 1;

            int minus = 2;

            for (int i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < widthBot; j++)
                    {
                        if (j >= n - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                }

                if (i != 0 && i + 1 != height)
                {
                    for (int j = 0; j < widthBot - 1; j++)
                    {
                        if (j == (n - minus))
                        {
                            minus++;
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }

                    Console.Write('*');
                }

                if (i + 1 == height)
                {
                    for (int j = 0; j < widthBot; j++)
                    {
                        Console.Write('*');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
