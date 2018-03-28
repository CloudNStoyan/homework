using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task1MythicalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pesho the mythical dragon has been trying to solve this task for years but with no luck. He was quite ashamed of the fact that
            //he can't solve it and for that reason, he never asked you for any help... until now.
            //He overcame his insecurity and he is now ready to become a master ninja ultra pro software engineer mythical programmer developer dragon. Quite the nice title, huh?

            //The magical number
            //You are given a number that is 3 digits long. Depending on the 3rd digit, you need to perform some calculations.
            /* If the 3rd digit is zero, find the product of the first two digits.
             * If the 3rd digit is between 0 and 5 inclusive, find the product of the first two digits and divide the result by the 3rd digit.
             * If the 3rd digit is larger than 5, find the sum of the first two digits and multiply the result by the 3rd digit.
             */

            string input = Console.ReadLine();
            double firstDigit = int.Parse(input[0] + "");
            double secondDigit = int.Parse(input[1] + "");
            double thirdDigit = int.Parse(input[2] + "");
            double result = 0;

            if (thirdDigit == 0)
            {
                result = firstDigit + secondDigit;
            } else if (thirdDigit > 0 && thirdDigit <= 5)
            {
                result = (firstDigit + secondDigit) / thirdDigit;
            } else if (thirdDigit > 5)
            {
                result = (firstDigit + secondDigit) * thirdDigit;
            }
            Console.WriteLine("{0:F2}",result);
        }
    }
}
