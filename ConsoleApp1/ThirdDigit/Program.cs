using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            if (number.ToString().Length < 3)
            {
                Console.WriteLine("False 0");
            }
            else
            {
                string numberStr = number.ToString();
                string filter = numberStr.Substring(numberStr.Length - 3);
                char filter2 = filter[filter.Length - 3];
                int result = (int) Char.GetNumericValue(filter2);
                if (result == 7)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False {0}", result);
                }
            }
        }
    }
}
