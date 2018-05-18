using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeros
{
    class Program
    {
        static string[] output = new string[5];

        static void Main(string[] args)
        {
            output[0] = "";

            int n = int.Parse(Console.ReadLine() + "");

            string binaryRepresentation = Convert.ToString(n, 2).PadLeft(16,'0');


            for (int i = 0; i < binaryRepresentation.Length; i++)
            {
                if (binaryRepresentation[i] == '0')
                {
                    AddZero();
                }
                else
                {
                    AddOne();
                }
            }

            Print();
        }

        static void AddZero()
        {
            if (output[0].Length < 1)
            {
                output[0] += "###";
                output[1] += "#.#";
                output[2] += "#.#";
                output[3] += "#.#";
                output[4] += "###";
            }
            else
            {
                output[0] += '.' + "###";
                output[1] += '.' + "#.#";
                output[2] += '.' + "#.#";
                output[3] += '.' + "#.#";
                output[4] += '.' + "###";
            }
        }

        static void AddOne()
        {
            if (output[0].Length < 1)
            {
                output[0] += ".#.";
                output[1] += "##.";
                output[2] += ".#.";
                output[3] += ".#.";
                output[4] += "###";
            }
            else
            {
                output[0] += '.' + ".#.";
                output[1] += '.' + "##.";
                output[2] += '.' + ".#.";
                output[3] += '.' + ".#.";
                output[4] += '.' + "###";
            }
        }

        static void Print()
        {
            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
            Console.WriteLine(output[2]);
            Console.WriteLine(output[3]);
            Console.WriteLine(output[4]);
        }
    }

}
