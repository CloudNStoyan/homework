using System;
using System.Globalization;
using System.Threading;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double each = p / 400;


            Console.WriteLine("{0:F3}",(n * s) * each);
        }
    }
}
