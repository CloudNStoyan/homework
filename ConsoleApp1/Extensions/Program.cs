using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var build = new StringBuilder();

            build.Append("az sum dobur");


            IEnumerable<int> result = from value in Enumerable.Range(0, 3) select value;
            IEnumerable<int> sResult = from value in Enumerable.Range(0, 3) select value;

            int a = result.TheSum();
            var b = result.Product(sResult);

            foreach (var o in b)
            {
                Console.WriteLine(o);
            }



        }
    }
}
