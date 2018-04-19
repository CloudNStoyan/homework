using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine() + "");
            int width = height;
            int center = Convert.ToInt32(Math.Floor(Convert.ToDouble(height / 2)));
            int inputWidth = width;

            for (int i = 0; i < height; i++)
            {
                if (i <= center)
                {
                    if (i != 0)
                    {
                        width -= 2;
                    }
                    int dot = (inputWidth - width) / 2;
                    for (int j = 0; j < dot; j++)
                    {
                        Console.Write('.');
                    }
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write('*');
                    }
                    for (int j = 0; j < dot; j++)
                    {
                        Console.Write('.');
                    }
                    Console.WriteLine();
                }
                else
                {
                    width += 2;
                    int dot = (inputWidth - width) / 2;
                    for (int j = 0; j < dot; j++)
                    {
                        Console.Write('.');
                    }
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write('*');
                    }
                    for (int j = 0; j < dot; j++)
                    {
                        Console.Write('.');
                    }
                    Console.WriteLine();
                }
            }
        }   
    }
}
