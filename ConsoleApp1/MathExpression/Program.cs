using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            // ((N^2 + 1 / (M * P) + 1337) / N - 128.523123123 * P) * Sin(M mod 180)

            double n = double.Parse(Console.ReadLine() + "");
            double m = double.Parse(Console.ReadLine() + "");
            double p = double.Parse(Console.ReadLine() + "");

            double result = ((Math.Pow(n, 2) + (1 / m * p) + 1337) / (n - (128.523123123 * p))) + Math.Sin(m % 180);
            Console.WriteLine("{0:F6}",result);
        }
    }
}
