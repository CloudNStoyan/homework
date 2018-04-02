using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
            //[0] Day
            //[1] Month
            //[2] Year
            var firstDate = Console.ReadLine().Split('.').Select(int.Parse).ToList();
            var secondDate = Console.ReadLine().Split('.').Select(int.Parse).ToList();

            DateTime dateOne = new DateTime(firstDate[2],firstDate[1],firstDate[0]);
            DateTime dateTwo = new DateTime(secondDate[2],secondDate[1],secondDate[0]);

            int daysBetween = 0;
            while (dateOne != dateTwo)
            {
                dateOne = dateOne.AddDays(1);
                daysBetween++;
            }

            Console.WriteLine(daysBetween);
        }
    }
}
