using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTextFromXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from given XML file all the text without the tags.

            StringBuilder result = new StringBuilder();
            string path = "text.xml";
            string text = "";

            if (File.Exists(path))
            {
                text = File.ReadAllText(path);
            }
            else
            {
                Console.WriteLine($"There is no file {path} in this directory!");
            }

            bool inTag = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    inTag = true;
                }

                if (!inTag)
                {
                    result.Append(text[i]);
                }

                if (text[i] == '>')
                {
                    inTag = false;
                    if (i + 1 < text.Length && text[i + 1] != '<')
                    {
                        result.Append(" ");
                    }
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
