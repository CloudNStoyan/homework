using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPVariables
{
    class Program
    {
        static List<string> lines = new List<string>();
        static List<string> variables = new List<string>();
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

            var linesForExtracting = new string[lines.Count];
            for (int i = 0; i < lines.Count; i++)
            {
                linesForExtracting[i] = lines[i];
            }

            var outputed = ExtractComments(linesForExtracting);

            foreach (string s in outputed)
            {
                Console.WriteLine(s);
            }

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
        }

        static List<string> ExtractComments(string[] lines)
        {
            List<string> comments = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                //Slash comment searcher!
                var slashCommentHolder = new StringBuilder();
                var inSlashComment = false;
                for (int j = 1; j < lines[i].Length; j++)
                {
                    if (!inSlashComment)
                    {
                        slashCommentHolder.Append(lines[i][j]);
                        if (j + 1 == lines[i].Length)
                        {
                            slashCommentHolder.Append(" ");
                        }
                    }

                    if (lines[i][j] == '/' && lines[i][j - 1] == '/')
                    {
                        inSlashComment = true;
                    }
                }

                if (slashCommentHolder.ToString() != "")
                {
                    comments.Add(slashCommentHolder.ToString().Trim());
                }
            }

            var inComment = false;
            var commentHolder = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                //The other kind comments
                for (int j = 1; j < lines[i].Length; j++)
                {
                    if (j + 1 < lines[i].Length && lines[i][j] == '*' && lines[i][j + 1] == '/')
                    {
                        inComment = false;
                    }

                    if (!inComment)
                    {
                        commentHolder.Append(lines[i][j]);
                    }
                    else
                    {
                        if (commentHolder.ToString() != "")
                        {
                            comments.Add(commentHolder.ToString().Trim());
                        }
                        commentHolder = new StringBuilder();
                    }

                    if (lines[i][j - 1] == '/' && lines[i][j] == '*')
                    {
                        inComment = true;
                    }
                }
            }

            return comments;
        }

    }
}
