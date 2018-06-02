using System;

namespace FindBits
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

            string desiredNumBinaryRepresent = Convert.ToString(desiredNum, 2).PadLeft(30, '0');
            string matchingNumBinaryRepresent = GetLastFiveBits(inNum);

            for (int i = 0; i < desiredNumBinaryRepresent.Length; i++)
            {
                char desiredChar = desiredNumBinaryRepresent[i];

                if (desiredChar == matchingNumBinaryRepresent[0] && i + 5 <= desiredNumBinaryRepresent.Length)
                {
                    if (desiredNumBinaryRepresent.Substring(i, 5) == matchingNumBinaryRepresent)
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        static string GetLastFiveBits(int num)
        {
            string numBinary = Convert.ToString(num, 2);
            if (numBinary.Length > 5)
            {
                numBinary = numBinary.Substring(numBinary.Length - 5, 5);
            }
            else if (numBinary.Length < 5)
            {
                numBinary = numBinary.PadLeft(5, '0');
            }

            return numBinary;
        }
    }
}
