using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstrologicalDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Calculate(input));
        }

        static int Calculate(string number)
        {
            if (number.Length == 1)
            {
                return int.Parse(number);
            }

            int result = 0;
            foreach (char c in number)
            {
                if (Char.IsNumber(c))
                {
                    result += int.Parse(c.ToString());
                }
            }

            while (result > 9)
            {
                result = Calculate(result.ToString());
            }

            return result;
        }
    }
}
