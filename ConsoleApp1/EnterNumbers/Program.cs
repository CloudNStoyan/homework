using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).
            //If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a 
            //program that enters 10 numbers:	a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100
            int times = 10;
            int used = 0;
            string[] numbers = new string[times];
            while (used < times)
            {
                numbers[used] = Console.ReadLine();
                used++;
            }
            StringBuilder result = new StringBuilder();
            used = 0;
            foreach (string number in numbers)
            {
                try
                {
                    if (!ReadNumber(int.Parse(number)))
                    {
                        throw new FormatException();
                    }
                    result.Append(number + " < ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number.");
                    break;
                }

                used++;
            }

            if (used == times)
            {
                try
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i > 0)
                        {
                            if (int.Parse(numbers[i]) < int.Parse(numbers[i - 1]))
                            {
                                throw new FormatException();
                            }
                        }
                    }
                    Console.WriteLine("1 < " + result + "100");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Exception");
                }
            }
        }

        static bool ReadNumber(int number)
        {
            try
            {
                if (number >= 100 || number <= 1)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
                return false;
            }
            return true;
        }
    }
}
