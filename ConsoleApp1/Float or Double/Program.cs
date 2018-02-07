using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_or_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            //Which of the following values can be assigned to a variable of type float and which to a variable of type
            //double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.




            // flaot precision 7 digits
            // double precision 15-16 digits
            // 34.567839023, 12.345, 8923.1234857, 3456.091

            double number0 = 34.567839023;
            float number1 = 12.345f;
            double number2 = 8923.1234857;
            float number3 = 3456.091f;

            Console.WriteLine(number0);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
        }
    }
}
