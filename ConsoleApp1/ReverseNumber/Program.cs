using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        public static int reverse(int number)
        {
            string strNumber = number.ToString();
            string temp = "";

            for (int i = strNumber.Length-1; i >= 0; i--)
            {
                temp += strNumber[i];
            }
            int output = int.Parse(temp);
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(reverse(456));
        }
    }
}
