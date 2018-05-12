using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeContent
{
    class Program
    {
        static List<string> _type = new List<string>();
        static List<string> _title = new List<string>();
        static List<string> _author = new List<string>();
        static List<string> _size = new List<string>();
        static List<string> _url = new List<string>();

        static StringBuilder _output = new StringBuilder();

        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    Console.Clear();
                    Console.WriteLine(_output.ToString().Trim());
                    break;
                }

                string command = line.Split(new char[] {':'}, 2)[0];
                string info = line.Split(new char[] {':'}, 2)[1];

                switch (command)
                {
                    case "Add book":
                        Add(command,info);
                        break;
                    case "Add movie":
                        Add(command, info);
                        break;
                    case "Add song":
                        Add(command, info);
                        break;
                    case "Add application":
                        Add(command, info);
                        break;
                    case "Update":
                        Update(info);
                        break;
                    case "Find":
                        Find(info);
                        break;
                }
            }
        }

        static void Add(string command, string info)
        {

            string type = FirstToUpper(command.Split(' ')[1].Trim());
            string title = info.Split(';')[0].Trim();
            string author = info.Split(';')[1].Trim();
            string size = info.Split(';')[2].Trim();
            string url = info.Split(';')[3].Trim();

            _type.Add(type);
            _title.Add(title);
            _author.Add(author);
            _size.Add(size);
            _url.Add(url);

            _output.AppendLine($"{type} added");
        }

        static void Update(string info)
        {
            string oldUrl = info.Split(';')[0].Trim();
            string newUrl = info.Split(';')[1].Trim();

            int howMany = 0;

            for (int i = 0; i < _url.Count; i++)
            {
                if (_url[i] == oldUrl)
                {
                    _url[i] = newUrl;
                    howMany++;
                }
            }

            _output.AppendLine($"{howMany} items updated");
        }

        static void Find(string info)
        {
            string title = info.Split(';')[0].Trim();
            int count = int.Parse(info.Split(';')[1].Trim());

            var finded = new List<string>();

            for (int i = 0; i < _title.Count; i++)
            {
                if (_title[i] == title)
                {
                    finded.Add(Get(i));
                }
            }

            finded.Sort();

            if (finded.Count > 0)
            {
                for (int i = 0; i < finded.Count; i++)
                {
                    if (i == count)
                    {
                        break;
                    }

                    _output.AppendLine(finded[i].Split('[')[1].Trim() + ": " + finded[i].Split('[')[0].Trim());
                }
            }
            else
            {
                _output.AppendLine("No items found");
            }
        }


        static string Get(int index)
        {
            var build = new StringBuilder();

            build.Append($"{_title[index]}; {_author[index]}; {_size[index]}; {_url[index]} [ {_type[index]}");
            
            return build.ToString();
        }

        static string FirstToUpper(string text)
        {
            var build = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                {
                    build.Append(text[i].ToString().ToUpper());
                }
                else
                {
                    build.Append(text[i]);
                }
            }

            return build.ToString();
        }

    }
}
