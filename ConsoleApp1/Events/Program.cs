using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
                    case "DeleteEvents":
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
            Console.Clear();
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
                if (events[i].ToLower().Contains(title.ToLower()))
                {
                    events.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        static void ListEvents(string date, int count)
        {
            var convertedEvents = new List<DateTime>();
            for (int i = 0; i < events.Count; i++)
            {
                var dateTime = GetTime(events[i]);
                convertedEvents.Add(dateTime);

            }
            
            DateTime fileDate = GetTime(date), closestDate = new DateTime();
            var theDates = convertedEvents;
            long min = long.MaxValue;

            foreach (DateTime theDate in theDates)
                if (Math.Abs(theDate.Ticks - fileDate.Ticks) < min)
                {
                    min = Math.Abs(theDate.Ticks - fileDate.Ticks);
                    closestDate = theDate;
                }

            string findDate = GetString(closestDate);
            int index = -1;
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].Contains(findDate))
                {
                    index = i;
                    break;
                }
            }

            var eve = events;

            if (index < 0 || index + 1 >= events.Count)
            {
                output.AppendLine("No events found");
            }
            else
            {
                var listedEvents = new List<string>();
                for (int i = 0; i < count && index < events.Count; i++)
                {
                    listedEvents.Add(events[index]);
                    index++;
                }

                var sortedEvents = listedEvents.OrderBy(x => x.Split('|')[0]).ThenBy(x => x.Split('|')[1]).ThenBy(x => x.Split('|')[2]);
                foreach (string listedEvent in sortedEvents)
                {
                    output.AppendLine(listedEvent);
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

        static string GetString(DateTime date)
        {
            var build = new StringBuilder();
            string year = date.Year + "";
            string month = date.Month + "";
            string day = date.Day + "";
            string hour = date.Hour + "";
            string minute = date.Minute + "";
            string second = date.Second + "";
            build.Append(year + "-");
            build.Append((month.Length > 1 ? month : "0" + month) + "-");
            build.Append((day.Length > 1 ? day : "0" + day) + "T");
            build.Append((hour.Length > 1 ? hour : "0" + hour) + ":");
            build.Append((minute.Length > 1 ? minute : "0" + minute) + ":");
            build.Append(second.Length > 1 ? second : "0" + second);
            return build.ToString();
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
