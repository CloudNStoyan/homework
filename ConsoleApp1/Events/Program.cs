using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static List<string> events = new List<string>();
        static StringBuilder output = new StringBuilder();
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var processed = new StringBuilder();
                for (int i = 1; i < input.Split(' ').Length; i++)
                {
                    processed.Append(input.Split(' ')[i] + " ");
                }

                string[] listEventsHolder = processed.ToString().Split('|');

                switch (input.Split(' ')[0])
                {
                    case "AddEvent":
                        AddEvent(processed.ToString());
                        break;
                    case "DeleteEvent":
                        DeleteEvent(processed.ToString());
                        break;
                    case "ListEvents":
                        ListEvents(listEventsHolder[0],int.Parse(listEventsHolder[1]));
                        break;
                    default:
                        Console.WriteLine($"Incorrect command! '{input.Split(' ')[0]}'");
                        break;
                }
            }

            Console.WriteLine(output.ToString().Trim());
        }

        static void AddEvent(string input)
        {
            events.Add(input);
            output.AppendLine("Event added");
        }

        static void DeleteEvent(string title)
        {
            int howMany = 0;
            int processed = 0;

            while (true)
            {
                if (Delete(title))
                {
                    howMany++;
                    Delete(title);
                }
                else
                {
                    break;
                }
            }

            output.AppendLine((howMany > 0) ? $"{howMany + 1} events deleted" : "No events found");
        }

        static bool Delete(string title)
        {
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].Contains(title))
                {
                    events.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        static void ListEvents(string date, int count)
        {
            int index = 0;
            for (int i = 0; i < events.Count; i++)
            {
                //2012-01-21T20:00:00 
                var dateTime = GetTime(events[i]);
                Console.WriteLine(dateTime);

                string line = events[i];
                if (line.Contains(date))
                {
                    index = i;
                    break;
                }
            }
        }

        static DateTime GetTime(string date)
        {
            string[] dates = date.Split('T');
            string yyyMMdd = dates[0].Trim();
            string hhMMss = dates[1].Split('|')[0].Trim();

            int year = int.Parse(yyyMMdd.Split('-')[0]);
            int month = int.Parse(yyyMMdd.Split('-')[1]);
            int day = int.Parse(yyyMMdd.Split('-')[2]);
            int hour = int.Parse(hhMMss.Split(':')[0]);
            int minute = int.Parse(hhMMss.Split(':')[1]);
            int second = int.Parse(hhMMss.Split(':')[2]);

            return new DateTime(year,month,day,hour,minute,second);
        }

        static void Print(List<string> list)
        {
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }



        /*
            string[] processed = input.Split('|');
            string date = processed.Split('|')[0].Trim();
            string title = processed[1].Trim();
            string location = processed[2].Trim();
         */
    }
}
