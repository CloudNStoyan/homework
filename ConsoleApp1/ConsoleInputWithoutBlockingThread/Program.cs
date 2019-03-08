using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleInputWithoutBlockingThread
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Im doing my stuff");
                Thread.Sleep(1000);
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(false);
                    Console.WriteLine(Environment.NewLine + "You pressed: " + key.Key);
                }
            }
        }
    }
}
