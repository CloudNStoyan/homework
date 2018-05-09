using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine() + "");
            int b = int.Parse(Console.ReadLine() + "");
            int c = int.Parse(Console.ReadLine() + "");

            int r = 0;
            switch (b)
            {
                case 2:
                    r = a % c;
                    break;
                case 4:
                    r = a + c;
                    break;
                case 8:
                    r = a * c;
                    break;
            }

            if (r % 4 == 0)
            {
                Console.WriteLine(r / 4);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(r % 4);
                Console.WriteLine(r);
            }
        }
    }
}
