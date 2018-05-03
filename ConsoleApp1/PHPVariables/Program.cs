using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PHPVariables
{
    class Program
    {
        static List<string> lines = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "?>")
                {
                    break;
                }
                lines.Add(line);
            }

            var cleanCode = Clean(lines);
            cleanCode = cleanCode.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            var output = Trim(GetVars(cleanCode)).Distinct().ToList();
            output.Sort((Comparison<String>)(
                (String left, String right) => {
                    return String.CompareOrdinal(left, right);
                }
            ));
            Console.Clear();
            Console.WriteLine(output.Count);
            Print(output);
        }

        static List<string> Trim(List<string> list)
        {
            var returnList = new List<string>();
            foreach (string s in list)
            {
                returnList.Add(s.Trim());
            }

            return returnList;
        }
            
        static void Print(List<string> withoutComments)
        {
            foreach (string s in withoutComments)
            {
                Console.WriteLine(s);
            }
        }

        static char GetBeforeChar(string line,int index)
        {
            char result = '|';

            for (int i = index - 1; i >= 0; i--)
            {
                if (line[i] != ' ')
                {
                    result = line[i];
                    break;
                }
            }

            return result;
        }
        
        static List<string> GetVars(List<string> lines)
        {
            var returnList = new List<string>();
            for (int lineIndex = 0; lineIndex < lines.Count; lineIndex++)
            {
                string line = lines[lineIndex];
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '$')
                    {
                        var build = new StringBuilder();
                        for (int j = i + 1; j < line.Length; j++)
                        {
                            if (!LetterCheck(line[j]))
                            {
                                i = j;
                                break;
                            }

                            build.Append(line[j]);
                        }
                        returnList.Add(build.ToString());
                    }
                }
            }

            return returnList;
        }

        static bool LetterCheck(char c)
        {
            string charList = '"' + @"!#$%&'()*+`-.,/:;<>=?[]/\^{}|~";
            foreach (char c1 in charList)
            {
                if (c1 == c)
                {
                    return false;
                }
            }

            return true;
        }

        static List<string> Clean(List<string> list)
        {
            var process1 = RemoveMultipleLineComments(list);
            var process2 = RemoveBetween(process1);
            var finished = RemoveAfter(process2);
            return finished;
        }


        static List<string> RemoveBetween(List<string> lines)
        {
            var returnList = new List<string>();
            for (int lineI = 0; lineI < lines.Count; lineI++)
            {
                string line = lines[lineI];
                var output = new StringBuilder();
                bool inTag = false;
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '"' && GetBeforeChar(line,i) == '=')
                    {
                        inTag = true;

                        int startIndex = line.IndexOf('"', i);
                        int length = line.IndexOf('"', startIndex + 1) - startIndex;

                        string temp = line.Substring(startIndex, length + 1);
                        if (!temp.Contains(@"\"))
                        {
                            inTag = false;
                        }
                    }

                    if (!inTag)
                    {
                        output.Append(line[i]);
                    }

                    if (i + 1 < line.Length && line[i + 1] == '"')
                    {
                        inTag = false;
                    }
                }
                returnList.Add(output.ToString());
            }

            return returnList;
        }

        static List<string> RemoveAfter(List<string> lines)
        {
            var returnList = new List<string>();
            for (int lineI = 0; lineI < lines.Count; lineI++)
            {
                string line = lines[lineI];
                var output = new StringBuilder();
                for (int i = 0; i < line.Length; i++)
                {
                    if (i + 1 < line.Length && line[i] == '/' && line[i + 1] == '/')
                    {
                        break;
                    }

                    if (i + 1 < line.Length && line[i] == '#')
                    {
                        break;
                    }

                    output.Append(line[i]);
                }
                returnList.Add(output.ToString());
            }

            return returnList;
        }

        static List<string> RemoveMultipleLineComments(List<string> lines)
        {
            var returnlist = new List<string>();
            bool inComment = false;

            for (int linesIndex = 0; linesIndex < lines.Count; linesIndex++)
            {
                string line = lines[linesIndex];
                var build = new StringBuilder();

                for (int lineIndex = 0; lineIndex < line.Length; lineIndex++)
                {
                    if (lineIndex + 1 < line.Length && line[lineIndex] == '/' && line[lineIndex + 1] == '*')
                    {
                        inComment = true;
                    }

                    if (!inComment)
                    {
                        build.Append(line[lineIndex]);
                    }

                    if (lineIndex - 1 >= 0 && line[lineIndex] == '/' && line[lineIndex - 1] == '*')
                    {
                        inComment = false;
                    }
                }

                returnlist.Add(build.ToString());
            }

            return returnlist;
        }
    }
}
