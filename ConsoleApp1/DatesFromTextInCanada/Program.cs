using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesFromTextInCanada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard 
            //date format for Canada.

            string[] text = Console.ReadLine().Split(' ');
            List<string> dates = new List<string>();

            foreach (string s in text)
            {
                if (s.Length == 10)
                {
                    if (s.IndexOf('.') == 2)
                    {
                        dates.Add(s);
                    }
                }
            }

            for (int i = 0; i < dates.Count; i++)
            {
                dates[i] = (DateTime.ParseExact(dates[i], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None)).ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern);
            }

            foreach (string date in dates)
            {
                Console.WriteLine(date);
            }
        }
    }
}
