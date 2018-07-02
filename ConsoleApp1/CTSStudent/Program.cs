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
            BitArray64 myArr = new BitArray64(2,3,4,5);
            BitArray64 myOther = new BitArray64(2,3,4,5);

            Console.WriteLine(myOther != myArr);
        }
    }
}
