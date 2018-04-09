using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanitizeText
{
    class Program
    {
        static void Main(string[] args)
        {
            // sanitize user input against XSS
            // < &#60;
            // > &#62;

            var badName = "<script>alert('hello gosho');</script>";

            string[] lines = badName.Split(new[] { Environment.NewLine },
                StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains('<'))
                {
                    lines[i] = lines[i].Replace("<", "&#60");
                }

                if (lines[i].Contains('>'))
                {
                    lines[i] = lines[i].Replace(">", "&#62");
                }
            }

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
    }
}
