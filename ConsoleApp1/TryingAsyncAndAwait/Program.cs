using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TryingAsyncAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpRequest("https://www.google.com/");
            Console.WriteLine("Dwarf Dwarf");
            Console.ReadLine();
        }

        private static async void HttpRequest(string url)
        {
            Console.WriteLine("Started fetching...");
            var client = new HttpClient();
            string response = await client.GetStringAsync(url);
            Console.WriteLine("Finished fetching.");

        }
    }
}
