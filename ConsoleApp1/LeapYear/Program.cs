using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static bool isLeapYear(int year)
        {
            if (DateTime.DaysInMonth(year, 2) == 29)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            //Write a program that reads a year from the console and checks whether it is a leap one.

            while (true)
            {
                int year = int.Parse(Console.ReadLine());
                if (isLeapYear(year))
                {
                    Console.WriteLine("Leap");
                }
                else
                {
                    Console.WriteLine("Common");
                }
            }
        }
    }
}
