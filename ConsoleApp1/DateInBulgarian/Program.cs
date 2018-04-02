using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateInBulgarian
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and 
            //time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
            //[0] Day
            //[1] Month
            //[2] Year
            //[0] Hour + 6
            //[1] Minute + 30
            //[2] Second

            string[] input = Console.ReadLine().Split(' ');
            var date = input[0].Split('.').Select(int.Parse).ToList();
            var time = input[1].Split(':').Select(int.Parse).ToList();

            DateTime bulgarianDateTime = new DateTime(date[2],date[1],date[0],time[0] + 6,time[1] + 30,time[2]);

            StringBuilder bulgarianTime = new StringBuilder();

            bulgarianTime.Append(bulgarianDateTime.Day + ".");
            bulgarianTime.Append(bulgarianDateTime.Month + ".");
            bulgarianTime.Append(bulgarianDateTime.Year + " ");
            bulgarianTime.Append(bulgarianDateTime.Hour + ":");
            bulgarianTime.Append(bulgarianDateTime.Minute + ":");
            bulgarianTime.Append(bulgarianDateTime.Second + " ");
            bulgarianTime.Append(bulgarianDateTime.DayOfWeek);

            Console.WriteLine(bulgarianTime.ToString());
        }
    }
}
