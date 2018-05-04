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
        static StringBuilder output = new StringBuilder();
        private static int i;

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

            commands = CleanWhiteSpaces(list).Split(';').Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            for (i = 0; i < commands.Count; i++)
            {
                RunCommands(commands[i]);
            }

            Console.WriteLine(output.ToString());
        }

        static void RunCommands(string command)
        {
            if (command.Split('(')[0] == "PRINT")
            {
                Print(command);
            }
            else
            {
                Loop(command);
            }
        }

        static void Loop(string command)
        {
            var str = command.Split(')').Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            //str[j].Split('(')[1]
            int times = 1;
            for (int j = 0; j < str.Count; j++)
            {
                if (str[j].StartsWith("PRINT"))
                {
                    for (int k = 0; k < times; k++)
                    {
                        output.Append(str[j].Split('(')[1]);
                    }
                    break;
                }

                string innerStr = str[j].Split('(')[1];
                if (innerStr.Contains(','))
                {
                    int a = int.Parse(innerStr.Split(',')[0]);
                    int b = int.Parse(innerStr.Split(',')[1]);

                    times *= (b - a) + 1;
                }
                else
                {
                    times *= int.Parse(innerStr);
                }
            }
        }

        static void Print(string command)
        {
            string message = command.Split('(')[1];
            message = message.Remove(message.Length - 1, 1);

            output.Append(message);
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
                    if (line[i] == '(' && build[build.Length - 1] == 'T')
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
