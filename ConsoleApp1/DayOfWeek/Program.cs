using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints to the console which day of the week is today. Use System.DateTime.
            DateTime a = new DateTime(2018, 3, 14);
            Console.WriteLine(a.DayOfWeek);
        }

    }
}

