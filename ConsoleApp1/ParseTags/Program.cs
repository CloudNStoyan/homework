using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.

            string input = Console.ReadLine();
            string upcaseOpen = "<upcase>";
            string upcaseClose = "</upcase>";
            int indexOpen = 0;
            int indexClose = 0;

            string upperInput = input.ToUpper();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[i]);
            }

            while (true)
            {
                indexOpen = input.IndexOf(upcaseOpen, indexOpen + upcaseOpen.Length);
                indexClose = input.IndexOf(upcaseClose, indexClose + upcaseClose.Length);

                if (indexOpen < 0)
                {
                    break;
                }
                
                for (int i = indexOpen + upcaseOpen.Length; i < indexClose; i++)
                {
                    result[i] = upperInput[i];
                }
            }

            Console.WriteLine(result.ToString());




        }
    }
}
