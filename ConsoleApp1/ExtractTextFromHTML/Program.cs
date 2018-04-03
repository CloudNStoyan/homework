using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTextFromHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
            List<string> documents = new List<string>();
            bool end = true;
            while (end)
            {
                string line = Console.ReadLine();
                documents.Add(line);
                if (line == "</html>")
                {
                    break;
                }
            }

            StringBuilder description = new StringBuilder();
            foreach (string document in documents)
            {
                if (document.Contains("title"))
                {
                    int indexOfTitle = document.IndexOf("title") + 6;
                    StringBuilder title = new StringBuilder();
                    for (int i = indexOfTitle;document[i] != '<'; i++)
                    {
                        title.Append(document[i]);
                    }
                    Console.WriteLine("Title: " + title);
                }
                else
                {
                    int time = 0;
                    bool inTag = false;
                    for (int i = 0; i < document.Length; i++)
                    {
                        if (document[i] == '<')
                        {
                            inTag = true;
                        }

                        if (inTag == false)
                        {
                            description.Append(document[i]);
                        }
                        else
                        {
                            if (time == 0)
                            {
                                description.Append(' ');
                            }

                            time++;
                        }

                        if (document[i] == '>')
                        {
                            inTag = false;
                        }
                    }
                }

                description.Append(" ");
            }

            Console.WriteLine("Text: " + description.ToString().Trim());
        }
    }
}
