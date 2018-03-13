using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class Program
    {
        static void printLastDigitNumber(int number)
        {
            string temp = number.ToString();
            int lastDigit = int.Parse(temp[temp.Length - 1].ToString());
            string print = "";
            switch (lastDigit)
            {
                case 0:
                    print = "Zero";
                    break;
                case 1:
                    print = "One";
                    break;
                case 2:
                    print = "Two";
                    break;
                case 3:
                    print = "Three";
                    break;
                case 4:
                    print = "Four";
                    break;
                case 5:
                    print = "Five";
                    break;
                case 6:
                    print = "Six";
                    break;
                case 7:
                    print = "Seven";
                    break;
                case 8:
                    print = "Eight";
                    break;
                case 9:
                    print = "Nine";
                    break;
            }
            Console.WriteLine(print);
        }
        static void Main(string[] args)
        {
            //Write a method that returns the last digit of given integer as an English word. Write a program that reads a number and prints the result of the method.
            printLastDigitNumber(13);
        }
    }
}
