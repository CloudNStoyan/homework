using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCalculate
{
    class Program
    {
        static void Main(string[] args)
        {/*  Problem 14. Integer calculations
        Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        Use variable number of arguments.  
        /*  Problem 15.* Number calculations *
        Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
        Use generic method (read in Internet about generic methods in C#).
        */
            int[] intArr = new int[] { -23, -1, 12, 45, 13, 2, 1, 90, 4 };
            double[] doubleArr = new double[] { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7, 7.8 };
            byte[] byteArr = new byte[] { 2, 1, 5, 3, 2 };

            Task<int> intSequence = new Task<int>(intArr);
            Console.WriteLine(intSequence);

            Task<double> doubleSequence = new Task<double>(doubleArr);
            Console.WriteLine(doubleSequence);

            Task<byte> byteSequence = new Task<byte>(byteArr);
            Console.WriteLine(byteSequence);
        }
    }
}
