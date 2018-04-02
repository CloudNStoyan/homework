using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the 
            //[protocol], [server] and [resource] elements.

            //http://telerikacademy.com/Courses/Courses/Details/212

            string url = Console.ReadLine();

            var match = Regex.Match(url == null ? "" : url, "(.*)://(.*?)(/.*)").Groups;

            Console.WriteLine("[protocol] = {0}",match[1]);
            Console.WriteLine("[server] = {0}",match[2]);
            Console.WriteLine("[resource] = {0}",match[3]);
        }
    }
}
