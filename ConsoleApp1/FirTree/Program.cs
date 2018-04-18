using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine() + "");
            int width = height - 2;
            int star = 1;

            for (int i = 0; i < height; i++)
            {
                if (i + 1 >= height)
                {
                    for (int j = 0; j < height - 2; j++)
                    {
                        Console.Write('.');
                    }

                    Console.Write('*');

                    for (int j = 0; j < height - 2; j++)
                    {
                        Console.Write('.');   
                    }

                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write('.');
                    }

                    for (int j = 0; j < star; j++)
                    {
                        Console.Write('*');
                    }

                    for (int j = 0; j < width; j++)
                    {
                        Console.Write('.');
                    }

                    star += 2;
                    width -= 1;
                    Console.WriteLine();
                }
            }
        }
    }
}
