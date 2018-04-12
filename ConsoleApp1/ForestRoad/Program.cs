using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine() + "");

            int height = (size * 2) - 1;
            int count = 0;
            bool left = true;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (count >= size)
                    {
                        left = false;
                        count -= 2;
                    }
                    if (count == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                if (left)
                {
                    count++;
                }
                else
                {
                    count--;
                }

                Console.WriteLine();
            }
        }
    }
}
