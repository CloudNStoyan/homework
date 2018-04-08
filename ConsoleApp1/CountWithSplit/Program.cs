using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWithSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            // count occurrences of a string within another string via split
            // NOTE: doesnt work for strings like "aa"

            var text = "baconaaaaaaa stuff bacon stuff stuff baconbacon yes";
            var splitText = text.Split(new[] { "yes" },StringSplitOptions.None);
            Console.WriteLine(splitText.Length - 1);
        }
    }
}
