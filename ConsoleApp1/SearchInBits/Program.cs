using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace SearchInBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            int occurences = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                occurences += HowManyOccurences(numbers[i], s);

            }

            Console.WriteLine(occurences);

        }

        static int HowManyOccurences(int desiredNum, int inNum)
        {
            int sum = 0;

            string desiredNumBinaryRepresent = Convert.ToString(desiredNum,2).PadLeft(30,'0');
            string matchingNumBinaryRepresent = GetLastFourBits(inNum);

            for (int i = 0; i < desiredNumBinaryRepresent.Length; i++)
            {
                char desiredChar = desiredNumBinaryRepresent[i];

                if (desiredChar == matchingNumBinaryRepresent[0] && i + 4 <= desiredNumBinaryRepresent.Length)
                {
                    if (desiredNumBinaryRepresent.Substring(i, 4) == matchingNumBinaryRepresent)
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        static string GetLastFourBits(int num)
        {
            string numBinary = Convert.ToString(num, 2);
            if (numBinary.Length > 4)
            {
                numBinary = numBinary.Substring(numBinary.Length - 4, 4);
            } else if (numBinary.Length < 4)
            {
                numBinary = numBinary.PadLeft(4, '0');
            }

            return numBinary;
        }
    }
}
