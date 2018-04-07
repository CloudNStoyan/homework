using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            // obscure a set of given words from an article
            // real life example: remove swearword from a forum post

            string censor = "!@#$%^&";

            string[] swearWords =
            {
                "qbulka",
                "plod",
                "banan"

            };

            string[] text = "Znaete li che qbulkata e plod koito e po hubav ot banana?".Split(' ');
            var result = new StringBuilder();

            foreach (string word in text)
            {
                bool isCensored = false;
                foreach (string swearWord in swearWords)
                {
                    if (word.Contains(swearWord))
                    {
                        isCensored = true;
                    }
                }

                if (isCensored)
                {
                    result.Append(" " + censor);
                }
                else
                {
                    result.Append(" " + word);
                }
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
