using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{

    class Program
    {
        static int countTimes(string array,int number)
        {
            int result = 0;
            char[] charArray = array.ToCharArray();
            foreach (char c in charArray)
            {
                string temp2 = number.ToString();
                if (c == temp2[0])
                {
                    result++;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            //Write a method that counts how many times given number appears in a given array. Write a test program to check if the method is working correctly.

            string input = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(countTimes(input,x));

        }
    }
}
