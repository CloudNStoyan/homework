using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFirstException = new InvalidRangeException<int>("Out of range",1,100);
            var mySecondException = new InvalidRangeException<DateTime>("Out of range",new DateTime(1980,1,1),new DateTime(2013,12,31));
        }
    }
}
