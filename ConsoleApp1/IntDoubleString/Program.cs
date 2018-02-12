using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the first line of the input, reads an int, double or string variable.
            //If the variable is int or double, the program increases it by one.
            //If the variable is a string, the program appends * at the end.
            //Print the result at the console. Use switch statement.

            int[] arrInt = new int[1];
            double[] arrDouble = new double[1];
            string[] arrString = new string[1];

            string input = Console.ReadLine();
            switch (input)
            {
                case "integer":
                    arrInt[0] = int.Parse(Console.ReadLine());
                    Console.WriteLine(arrInt[0] + 1);
                    break;
                case "real":
                    arrDouble[0] = double.Parse(Console.ReadLine());
                    Console.WriteLine(arrDouble[0] + 1);
                    break;
                case "text":
                    arrString[0] = Console.ReadLine();
                    Console.WriteLine(arrString[0] + "*");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

         

            


        }
    }
}
