using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            var myself = new Person("Stoyan",3);

            Console.WriteLine(myself);

            BitArray64 myArr = new BitArray64(2,3,4,5);
        }
    }
}
