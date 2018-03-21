using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workdays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that calculates the number of workdays between today and a given date, passed as parameter.
            //Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
            string input = Console.ReadLine();
            int inputYear = int.Parse("" + input[0] + input[1] + input[2] + input[3]);
            int inputMonth = int.Parse("" + input[5] + input[6]);
            int inputDay = int.Parse("" + input[8] + input[9]);
            int workDays = 0;

            var holidays = new Dictionary<string, string>
            {
                {"2019-01-01","New Year's Day"},
                {"2019-02-14","Valentine's Day"},
                {"2019-03-01","First March"},
            };

            DateTime toDate = new DateTime(inputYear,inputMonth,inputDay);
            DateTime fromDate =  DateTime.Today;
            DayOfWeek day = fromDate.DayOfWeek;
            while (day != DayOfWeek.Friday)
            {
                fromDate = fromDate.AddDays(1);
                day = fromDate.DayOfWeek;
                workDays++;
            }

            string format = "yyyy-MM-dd";
            string temp = fromDate.ToString(format);
            while (fromDate != toDate)
            {
                if (fromDate.DayOfWeek != DayOfWeek.Sunday && fromDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    if (holidays.ContainsKey(temp))
                    {
                        Console.WriteLine(holidays[temp]);
                    }
                    else
                    {
                        workDays++;
                    }

                    temp = fromDate.ToString(format);

                }
                fromDate = fromDate.AddDays(1);
            }

            Console.WriteLine(workDays);
        }
    }
}
