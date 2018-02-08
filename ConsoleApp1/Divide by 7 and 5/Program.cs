using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int filter = (input / 7) % 2;
            int filter2 = (input / 5) % 2;
            if (filter == 0 && filter2 == 0)
            {
                Console.WriteLine("true {0}",input);
            }
            else
            {
                Console.WriteLine("false {0}", input);
            }
        }
    }
}
