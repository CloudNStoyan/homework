using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare an integer variable and assign it with the value 254 in hexadecimal format (0x###).
            //Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is 254.


            byte number0 = 0xFE; // byte range min 0 max 255 ; Hexadecimal Format keyword 0x
            Console.WriteLine(number0);

        }
    }
}
