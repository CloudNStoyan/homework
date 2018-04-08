using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            // compress a string by replacing a sequences of repeating characters with the character followed by the count of the repetitions

            string text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab baaaaa dwwwwww errrraa";

            Console.WriteLine(Compress(text));
        }

        static string Compress(string text)
        {
            var result = new StringBuilder();
            int count = 1;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i - 1] == text[i])
                {
                    count++;
                }
                else
                {
                    if (count >= 2)
                    {
                        result.Append(text[i - 1]);
                        result.Append(count);
                    }

                    count = 1;
                }

                if (i == text.Length - 1 && count >= 2)
                {
                    result.Append(text[i - 1]);
                    result.Append(count);
                }
            }

            return result.ToString();
        }
    }
}
