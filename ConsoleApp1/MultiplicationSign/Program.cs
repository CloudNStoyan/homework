using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
            //Use a sequence of if operators.

            double inputA = double.Parse(Console.ReadLine());
            double inputB = double.Parse(Console.ReadLine());
            double inputC = double.Parse(Console.ReadLine());

            if ((inputA == 0) || (inputB == 0) || (inputC == 0))
            {
                Console.WriteLine("0");
            } else if (inputA < 0)
            {
                if (inputB < 0)
                {
                    if (inputC < 0)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        Console.WriteLine("+");
                    }
                }
                else
                {
                    if (inputC < 0)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        Console.WriteLine("+");
                    }
                }
            }
            else if (inputA > 0)
            {
                if (inputB < 0)
                {
                    if (inputC < 0)
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                else
                {
                    if (inputC < 0)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        Console.WriteLine("+");
                    }
                }
            }
        }
    }
}
