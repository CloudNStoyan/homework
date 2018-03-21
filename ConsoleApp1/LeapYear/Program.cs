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
