using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class Program
    {
        static void Convert(string input)
        {
            string result = "";
            string zeros = "";
            if (input.Length % 4 != 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    zeros += "0";
                    result = zeros + input;
                    if (result.Length % 4 == 0)
                    {
                        break;
                    }

                }
            }
            else
            {
                result = input;
            }
            var map = new Dictionary<string, string>
            {
                {"0000","0"},
                {"0001","1"},
                {"0010","2"},
                {"0011","3"},
                {"0100","4"},
                {"0101","5"},
                {"0110","6"},
                {"0111","7"},
                {"1000","8"},
                {"1001","9"},
                {"1010","A"},
                {"1011","B"},
                {"1100","C"},
                {"1101","D"},
                {"1110","E"},
                {"1111","F"}
            };
            string output = "";
            if (result.Length == 4)
            {
                output = map[result];
            }
            else
            {
                int j = 0;
                for (int i = 0; i < result.Length / 4; i++)
                {
                    string temp = "" + result[j] + result[j + 1] + result[j + 2] + result[j + 3];
                    output += map[temp];
                    j += 4;
                }
            }
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            //Write a program to convert binary numbers to hexadecimal numbers (directly).
            while (true)
            {
                string binary = Console.ReadLine();
                Convert(binary);    
            }
        }
    }
}
