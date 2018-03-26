using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1BirdsAndFeathers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your task is to find the average feathers count per bird and apply some more calculations on the result. 
            //If the birds count is an even number - multiply the result by the magic number 123123123123
            //If the birds count is an odd number - divide the result by the magic number 317.

            decimal birds = decimal.Parse(Console.ReadLine() + "");
            decimal feathers = decimal.Parse(Console.ReadLine() + "");
            decimal result = 0;

            decimal averageFeathers = feathers / birds;
            if (averageFeathers % 2 == 0)
            {
                result = averageFeathers * 123123123123;
            }
            else
            {
                result = averageFeathers / 317;
            }

            Console.WriteLine("{0:F4}",result);
        }
    }
}
