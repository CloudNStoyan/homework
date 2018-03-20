using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFloatingPoint
{
    class Program
    {
        static string FloatNumberToBinary(float number)
        {
            int dec = BitConverter.ToInt32(BitConverter.GetBytes(number), 0);

            return Convert.ToString(dec, 2);
        }

        static string GetExponent(string binary)
        {
            return binary.Substring(0, 8);
        }

        static string GetMantissa(string binary)
        {
            return binary.Substring(8);
        }

        static void Main()
        {
            //Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
            float number = float.Parse(Console.ReadLine());
            int sign = number < 0 ? 1 : 0;
            number = Math.Abs(number);
            string binary = FloatNumberToBinary(number);
            if ((int) number == 0 || (int) number == 1)
            {
                binary = "0" + binary;
            }

            bool hasSign = sign == 1;
            if (hasSign)
            {
                Console.WriteLine("Sign: (minus)");
            }
            else
            {
                Console.WriteLine("Sign: (plus)");
            }
            Console.WriteLine("Exponent: {0}", GetExponent(binary));
            Console.WriteLine("Mantissa: {0}\n", GetMantissa(binary));
        }
    }
}
