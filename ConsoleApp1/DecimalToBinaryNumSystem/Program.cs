using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryNumSystem
{
    class Program
    {
        static void Convert(decimal n)
        {
            string temp = "";
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    temp += "0";
                }
                else
                {
                    temp += "1";
                }
                n = Math.Floor(n / 2);
            }
            string output = "";
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                output += temp[i];
            }
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            Convert(n);
        }
    }
}
