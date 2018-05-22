using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_9
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
                case 3:
                    r = a + c;
                    break;
                case 6:
                    r = a * c;
                    break;
                case 9:
                    r = a % c;
                    break;
            }

            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(r % 3);
                Console.WriteLine(r);
            }
        }
    }
}
