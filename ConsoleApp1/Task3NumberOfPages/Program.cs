using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3NumberOfPages
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            for (int page = 1; digits > 0; page++)
            {
                pages++;
                if (page < 10)
                {
                    digits -= 1;
                } else if (page < 100)
                {
                    digits -= 2;
                } else if (page < 1000)
                {
                    digits -= 3;
                } else if (page < 10000)
                {
                    digits -= 4;
                } else if (page < 100000)
                {
                    digits -= 5;
                } else if (page < 1000000)
                {
                    digits -= 6;
                }
            }
            Console.WriteLine(pages);
        }
    }
}
