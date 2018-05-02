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

            var cleanedCode = ClearComments(lines);
            Print(cleanedCode);
            var variables = GetVars(cleanedCode);
            variables.Sort();
            Console.Clear();
            Console.WriteLine(variables.Count);
            Print(variables);
        }

        static void Print(List<string> withoutComments)
        {
            foreach (string s in withoutComments)
            {
                Console.WriteLine(s);
            }
        }

        static List<string> ClearComments(List<string> lines)
        {
            var withoutComments = new List<string>();
            var output = new List<string>();
            bool isNotComment = true;

            for (int i = 0; i < lines.Count; i++)
            {
                var build = new StringBuilder();
                string line = lines[i];
                string tempIndex = "";
                bool sameLine = false;

                for (int j = 0; j < line.Length;j++)
                {
                    if ((j + 1 < line.Length && line[j] == '/' && line[j + 1] == '/') || (j + 1 < line.Length && line[j] == '/' && line[j + 1] == '*'))
                    {
                        isNotComment = false;
                    }

                    if (isNotComment)
                    {
                        build.Append(line[j]);
                    }

                    if ((j - 1 >= 0 && line[j] == '/' && line[j - 1] == '*'))
                    {
                        isNotComment = true;
                    }
                }
                withoutComments.Add(build.ToString());
                
            }

            for (int i = 0; i < withoutComments.Count; i++)
            {
                string line = withoutComments[i];
                for (int j = 0; j < line.Length; j++)
                {
                    char before = GetBeforeChar(line, j);
                    if (line[j] == '"' && before == '=')
                    {
                        int startIndex = line.IndexOf('"');
                        int length = line.IndexOf('"', startIndex + 1) - startIndex;
                        line = line.Remove(startIndex, length);
                    }
                }
                output.Add(line);
            }

            return output;
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
            var variables = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                bool inVar = false;

                var variable = new StringBuilder();
                for (int j = 0; j < line.Length; j++)
                {
                    char c = line[j];
                    if (inVar && !char.IsLetter(c) && !char.IsDigit(c))
                    {
                        variables.Add(variable.ToString());
                        variable.Clear();
                        inVar = false;

                    }

                    if (inVar)
                    {
                        variable.Append(line[j]);
                    }

                    if (line[j] == '$')
                    {
                        inVar = true;
                    }
                }
            }

            return variables;
        }

    }
}
