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

            if (input % 7 == 0 && input % 5 == 0)
            {
                Console.WriteLine("True {0}", input);
            } else
            {
                Console.WriteLine("False {0}", input);
            }
           
        }
    }
}
