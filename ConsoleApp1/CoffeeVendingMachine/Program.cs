using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            
            double[] trays = new double[5];
            for (int i = 0; i < trays.Length; i++)
            {
                trays[i] = double.Parse(Console.ReadLine() + "");
            }

            trays[0] = trays[0] * 0.05;
            trays[1] = trays[1] * 0.10;
            trays[2] = trays[2] * 0.20;
            trays[3] = trays[3] * 0.50;
            trays[4] = trays[4] * 1;

            double machineCurrency = trays.Sum();

            double a = double.Parse(Console.ReadLine() + "");
            double p = double.Parse(Console.ReadLine() + "");

            if (a > p && (machineCurrency - (a - p)) < 0)
            {
                Console.WriteLine("No {0:F2}",Math.Abs(machineCurrency - (a - p)));
            } else if (p > a)
            {
                Console.WriteLine("More {0:F2}",(p - a));
            } else if (a > p)
            {
                Console.WriteLine("Yes {0:F2}" ,(machineCurrency - (a - p)));
            }
        }
    }
}
