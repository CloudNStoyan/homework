using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            int[] intArray = new int[input.Length];
            double sum = 0;
            int j = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(charArray[i]))
                {
                    intArray[j] = int.Parse(charArray[i].ToString());
                }
                switch (charArray[i].ToString())
                {
                    case "A":
                        intArray[j] = 10;
                        break;
                    case "B":
                        intArray[j] = 11;
                        break;
                    case "C":
                        intArray[j] = 12;
                        break;
                    case "D":
                        intArray[j] = 13;
                        break;
                    case "E":
                        intArray[j] = 14;
                        break;
                    case "F":
                        intArray[j] = 15;
                        break;
                    default:
                        break;
                }
                double level = Math.Pow(16, j);
                sum += (intArray[j] * level);
                j--;
            }
            Console.WriteLine(sum);
        }
    }
}
