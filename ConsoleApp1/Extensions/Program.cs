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

        }

        static string[] FirstBeforeLast(string[] arr)
        {
            return arr.Where(name => string.Compare(name.Split(' ')[0], name.Split(' ')[1]) > 0).OrderBy(name => name).ToArray();
        }
    }
}
