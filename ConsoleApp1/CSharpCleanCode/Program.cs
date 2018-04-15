using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCleanCode
{
    class Program
    {
        static void Main(string[] args)
        {

            int lineNumber = int.Parse(Console.ReadLine() + "");
            string[] lines = new string[lineNumber];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Console.ReadLine();
            }
            List<string> cleanCode = new List<string>();

            bool inSlashComment = false;
            bool inMultilineComment = false;
            for (int i = 0; i < lines.Length; i++)
            {
                var line = new StringBuilder();
                bool isNotEmpty = false;
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == '/' && j + 1 < lines[i].Length && lines[i][j + 1] == '/' && j - 1 >= 0 && lines[i][j - 1] != '"')
                    {
                        inSlashComment = true;
                    }

                    if (lines[i][j] == '/' && j + 1 < lines[i].Length && lines[i][j + 1] == '*' && j - 1 >= 0 && lines[i][j - 1] != '"')
                    {
                        inMultilineComment = true;
                    }

                    if (!inSlashComment && !inMultilineComment)
                    {
                        line.Append(lines[i][j]);
                    }

                    if (j + 1 >= lines[i].Length)
                    {
                        inSlashComment = false;
                    }

                    if (lines[i][j] == '/' && j - 1 >= 0 && lines[i][j - 1] == '*')
                    {
                        inMultilineComment = false;
                    }
                }

                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] != ' ')
                    {
                        isNotEmpty = true;
                        break;
                    }
                }

                if (isNotEmpty)
                {
                    Console.WriteLine(line);
                    cleanCode.Add(line.ToString());
                }
            }
        }

        static void Print(List<string> lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
