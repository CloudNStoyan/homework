using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatVsAppend
{
    class Program
    {
        static void Main(string[] args)
        {
            //compare ConcatvsAppend

            ComparePerfomance();
        }

        static void ComparePerfomance()
        {
            var time = new Stopwatch();

            const int repeat = 200000;

            string str = "";

            time.Start();
            for (int i = 0; i < repeat; i++)
            {
                str += "a";
            }

            time.Stop();

            Console.WriteLine(time.Elapsed + " Concat");

            var builder = new StringBuilder();

            time.Restart();
            time.Start();
            for (int i = 0; i < repeat; i++)
            {
                builder.Append('a');
            }
            time.Stop();

            Console.WriteLine(time.Elapsed + " Append");
        }
    }
}
