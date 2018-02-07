using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to 
            //represent the following values: 52130, -115, 4825932, 97, -10000. 
            //Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

            ushort number0 = 52130; // ushort range min 0 max 65,535
            sbyte number1 = -115; // sbyte range min -128 max 127
            int number2 = 4825932; // int range min -2,147,483,648
            sbyte number3 = 97; // sbye range min -128 max 127
            short number4 = -10000; // short range min -32,768 max 32,767

            Console.WriteLine(number0);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
        }
    }
}
