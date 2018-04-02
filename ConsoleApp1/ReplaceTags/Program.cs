using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that replaces in a HTML document given as string all the tags <a href="URL">TEXT</a> with corresponding 
            //markdown notation [TEXT](URL).

            string input = Console.ReadLine();

            StringBuilder htmlDocument = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                htmlDocument.Append(input[i]);
            }

            for (int i = 0; i < htmlDocument.Length; i++)
            {
                if (htmlDocument[i] == '<')
                {
                    if (htmlDocument[i + 1] == 'a')
                    {
                        string tag = "";
                        int from = i;
                        int length = 0;
                        for (int j = i; htmlDocument.Length > j; j++)
                        {
                            if (j != i) {
                                if (htmlDocument[j] != '<')
                                {
                                    tag += htmlDocument[j];
                                }
                                else
                                {
                                    tag += htmlDocument[j];
                                    break;
                                }
                            }
                            else
                            {
                                tag += htmlDocument[j];
                            }

                            length++;
                        }
                        htmlDocument.Replace(tag,EditedTag(tag)).Replace("/a>","");
                    }
                }
            }

            Console.WriteLine(htmlDocument.ToString());
        }

        static string EditedTag(string tag)
        {
            int siteStardIndex = tag.IndexOf('"', 0) + 1;
            int siteLength = tag.IndexOf('"', 9) - siteStardIndex;

            int textStardIndex = tag.IndexOf('"', 9) + 2;
            int textLength = tag.Length - tag.IndexOf('"', 9) - 3;

            string site = "(" + tag.Substring(siteStardIndex, siteLength) + ")";
            string text = "[" + tag.Substring(textStardIndex, textLength) + "]";

            return text + site;
        }
    }
}
