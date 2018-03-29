using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Messages
{
    class Program
    {
        static int Decrypt(string number)
        {
            var strToNumber = new Dictionary<string, int>
            {
                {"cad", 0},
                {"xoz", 1},
                {"nop", 2},
                {"cyk", 3},
                {"min", 4},
                {"mar", 5},
                {"kon", 6},
                {"iva", 7},
                {"ogi", 8},
                {"yan", 9}
            };
            int count = 0;
            string temp = "";
            string result = "";
            for (int i = 0; i < number.Length / 3; i++)
            {
                temp = "" + number[count] + number[count + 1] + number[count + 2];
                result += strToNumber[temp];
                count += 3;
            }
            return int.Parse(result);
        }

        static string Encrypt(int number)
        {
            var numToString = new Dictionary<int, string>
            {
                {0, "cad"},
                {1, "xoz"},
                {2, "nop"},
                {3, "cyk"},
                {4, "min"},
                {5, "mar"},
                {6, "kon"},
                {7, "iva"},
                {8, "ogi"},
                {9, "yan"}
            };
            string result = "";
            string numberInStr = number.ToString();
            for (int j = 0; j < numberInStr.Length; j++)
            {
                result += numToString[int.Parse(numberInStr[j].ToString())];
            }
            return result;
        }
        static void Substract(string fNumber, string sNumber)
        {
            int number1 = Decrypt(fNumber);
            int number2 = Decrypt(sNumber);
            Console.WriteLine(Encrypt(number1 - number2));
        }

        static void Add(string fNumber, string sNumber)
        {
            int number1 = Decrypt(fNumber);
            int number2 = Decrypt(sNumber);
            Console.WriteLine(Encrypt(number1 + number2));
        }

        static void Multiply(string fNumber, string sNumber)
        {
            int number1 = Decrypt(fNumber);
            int number2 = Decrypt(sNumber);
            Console.WriteLine(Encrypt(number1 * number2));
        }

        static void Divide(string fNumber, string sNumber)
        {
            int number1 = Decrypt(fNumber);
            int number2 = Decrypt(sNumber);
            Console.WriteLine(Encrypt(number1 / number2));
        }

        static void Commands(string command)
        {
            switch (command)
            {
                case "//":
                    for (int i = 0; i < 9; i++)
                    {
                        Console.WriteLine(Encrypt(i) + " | " + i);
                    }
                    Console.WriteLine();
                    break;
                case "..":
                    Console.Clear();
                    break;
            }
        }
        static void Main(string[] args)
        {
            //Joro and Gosho are very good friends. They love to talk and devise master plans for world domination.
            //Yet, John the Evil wants to steal their ideas. So, they have built an encryption system for communication.
            //The encryption system consists of adding or subtracting numbers in their GeorgeTheGreat numeral system.
            //The GeorgeTheGreat numeral system has exactly 10 different digits and each digit consists of 3 chacters as follows:

            /* cad | 0
             * xoz | 1
             * nop | 2
             * cyk | 3
             * min | 4
             * mar | 5
             * kon | 6
             * iva | 7
             * ogi | 8
             * yan | 9
             */

            //Your task is to calculate the result of the operation, by given two numbers in GeorgeTheGreat numeral system and an operator (subtraction or addition)
            var commands = new Dictionary<string,int>
            {
                {"//", 0},
                {"..", 0}
            };
            while (true)
            {
                string firstNumber = Console.ReadLine();
                if (commands.ContainsKey(firstNumber))
                {
                    Commands(firstNumber);
                }
                else
                {
                    string ope = Console.ReadLine();
                    string secondNumber = Console.ReadLine();

                    switch (ope)
                    {
                        case "-":
                            Substract(firstNumber, secondNumber);
                            break;
                        case "+":
                            Add(firstNumber, secondNumber);
                            break;
                        case "*":
                            Multiply(firstNumber, secondNumber);
                            break;
                        case "/":
                            Divide(firstNumber, secondNumber);
                            break;
                        default:
                            Console.WriteLine("The operator is unavailable");
                            break;
                    }
                }
            }
        }
    }
}
