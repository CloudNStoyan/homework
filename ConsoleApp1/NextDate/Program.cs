using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine() + "");
            int month = int.Parse(Console.ReadLine() + "");
            int year = int.Parse(Console.ReadLine() + "");


            var date = new DateTime(year,month,day);
            date = date.AddDays(1);
            Console.WriteLine(date.Day + "." + date.Month + "." + date.Year);
        }
    }
}
