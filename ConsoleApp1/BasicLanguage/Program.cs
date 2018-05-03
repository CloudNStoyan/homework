using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLanguage
{
    class Program
    {

        static List<string> list = new List<string>();
        static List<string> commands;

        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (IsExit(input))
                {
                    if (input.Length > 5)
                    {
                        input = ReplaceLastOccurrence(input, "EXIT;", "");
                        list.Add(input);
                    }
                    break;
                }
                list.Add(input);
            }

            commands = CleanWhiteSpaces(list).Split(';').ToList();

            Run();

        }

        static void Run()
        {
            Print(commands[0]);
        }

        static void Print(string command)
        {
            string message = command.Split('(')[1];
            message = message.Remove(message.Length - 1, 1);

            Console.WriteLine(message);
        }

        static string CleanWhiteSpaces(List<string> text)
        {
            var build = new StringBuilder();
            bool inTag = false;

            for (int lineNumber = 0; lineNumber < text.Count; lineNumber++)
            {
                string line = text[lineNumber];

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '(')
                    {
                        inTag = true;
                    }

                    if (inTag)
                    {
                        build.Append(line[i]);
                    }
                    else
                    {
                        if (line[i] != '\n' && line[i] != ' ')
                        {
                            build.Append(line[i]);
                        }
                    }

                    if (line[i] == ')')
                    {
                        inTag = false;
                    }
                }

            }

            return build.ToString();
        }

        static bool IsExit(string text)
        {
            if (text[text.Length - 1] == ';' && text[text.Length - 2] == 'T' && text[text.Length - 3] == 'I' && text[text.Length - 4] == 'X' && text[text.Length - 5] == 'E')
            {
                return true;
            }

            return false;
        }

        public static string ReplaceLastOccurrence(string Source, string Find, string Replace)
        {
            int place = Source.LastIndexOf(Find);

            if (place == -1)
                return Source;

            string result = Source.Remove(place, Find.Length).Insert(place, Replace);
            return result;
        }

    }
}
