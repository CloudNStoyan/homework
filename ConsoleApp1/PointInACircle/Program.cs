using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());


            double number = (x - 1) * (x - 1) + (y - 1) * (y - 1);

            if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 2 * 2)
            {
                Console.WriteLine("true {0}",number);
            }
            else
            {
                Console.WriteLine("false {0}",number);  
            }

        }
    }
}
