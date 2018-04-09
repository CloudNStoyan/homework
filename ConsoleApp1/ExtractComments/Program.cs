using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractComments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extract comments

            var code = @"/* just a meaningless comment */
namespace ExtractComments
{
// my usings are here
using System;
// penka e
class Startup
{
// otivam na kafe s ivan
static void Main()
{
var code = ""; /* koito go e pisal tozi kod,
sdflkjdsjfldsfjlkdsfjdslkfjdlkf
ne e dobre */
}
// javascript
}
}
// za cvqt
";
            var list = ExtractComments(code);
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }

        static List<string> ExtractComments(string code)
        {
            string[] lines = code.Split(new[] { Environment.NewLine },
                StringSplitOptions.None);
            List<string> comments = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                //Slash comment searcher!
                var slashCommentHolder = new StringBuilder();
                var inSlashComment = false;
                for (int j = 1; j < lines[i].Length; j++)
                {
                    if (inSlashComment)
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

                    if (inComment)
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
