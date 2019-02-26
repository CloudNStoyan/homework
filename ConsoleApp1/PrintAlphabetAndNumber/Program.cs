using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAlphabetAndNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int letterCount = 0;
            int numberCount = 0;
            int specialCount = 0;


            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    letterCount++;
                } else if (char.IsDigit(character))
                {
                    numberCount++;
                }
                else
                {
                    specialCount++;
                }
            }

            Console.WriteLine("Number of Alphabets in the string is : " + letterCount);
            Console.WriteLine("Number of Digits in the string is : " + numberCount);
            Console.WriteLine("Number of Special characters in the string is : " + specialCount);
        }
    }
}
