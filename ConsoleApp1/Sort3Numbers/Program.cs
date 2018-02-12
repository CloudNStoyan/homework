using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters 3 real numbers and prints them sorted in descending order. 
            //Use nested if statements.
            //Don’t use arrays and the built-in sorting functionality.

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double small = 0;
            double medium = 0;
            double high = 0;

            if (a > b && a > c)
            {
                high = a;
            }
            else if (b > a && b > c)
            {
                high = b;
            }
            else if (c > b && c > a)
            {
                high = c;
            }

            if (high == a)
            {
                if (b > c)
                {
                    medium = b;
                }
                else
                {
                    medium = c;
                }
            } else if (high == b)
            {
                if (a > c)
                {
                    medium = a;
                }
                else
                {
                    medium = c;
                }
            } else if (high == c)
            {
                if (b > a)
                {
                    medium = b;
                }
                else
                {
                    medium = a;
                }
            }

            if (medium == a)
            {
                if (high == b)
                {
                    small = c;
                }
                else
                {
                    small = b;
                }
            } else if (medium == b)
            {
                if (high == a)
                {
                    small = c;
                }
                else
                {
                    small = a;
                }
            } else if (medium == c)
            {
                if (high == a)
                {
                    small = b;
                }
                else
                {
                    small = a;
                }
            }

            Console.WriteLine(small + " " + medium + " " + high);
        }
    }
}
