using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
            //Print the variable values before and after the exchange.

            int a = 5;
            int b = 10;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            a = 10;
            b = 5;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }
    }
}
