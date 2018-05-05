using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateHTML
{
    class Program
    {
        static List<string> HtmlTags = new List<string>();
        static StringBuilder output = new StringBuilder();
        static void Main(string[] args)
        {
            
            int nTimes = int.Parse(Console.ReadLine() + "");

            for (int i = 0; i < nTimes; i++)
            {
                HtmlTags.Add(Console.ReadLine());
            }


            foreach (string htmlTag in HtmlTags)
            {
                if (Validate(htmlTag))
                {
                    Console.WriteLine("VALID");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }


        static bool Validate(string html)
        {
            string[] tags = html.Split('>');

            for (int i = 0; i < tags.Length; i++)
            {

            }

            return true;
        }
    }
    
}
