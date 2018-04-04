using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string name = Console.ReadLine();
                    string url = Console.ReadLine();

                    var client = new WebClient();
                    client.DownloadFile(url, name);
                }
                catch (WebException)
                {
                    Console.WriteLine(
                        "The url is not valid or the file doesn't exist or error occured while downloading data.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Enter url!");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Something wen't wrong!");
                    break;
                }
            }
        }
    }
}
