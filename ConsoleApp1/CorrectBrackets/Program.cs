using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to check if in a given expression the ( and ) brackets are put correctly.
            string input = Console.ReadLine() + "";

            char[] tempInput = new char[input.Length];
            for (int i = 0; i < tempInput.Length; i++)
            {
                tempInput[i] = input[i];
            }

            bool correct = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    for (int j = i; j < input.Length; j++)
                    {
                        if (input[j] == ')')
                        {
                            tempInput[i] = ' ';
                            tempInput[j] = ' ';
                            input = new string(tempInput);
                            break;
                        }
                    }
                }
            }

            foreach (char c in input)
            {
                if (c != ' ')
                {
                    correct = false;
                    break;
                }
            }

            Console.WriteLine(correct);
        }
    }
}
