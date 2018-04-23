using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() + "");
            string[] lines = new string[n];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Console.ReadLine();
                string line = lines[i];
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == '<')
                    {

                    }
                }
            }
        }


        static bool Closed(string line, int index)
        {
            var tag = new StringBuilder();
            for (int i = index; i < line.Length; i++)
            {
                if (line[i] == '>')
                {
                    break;
                }
                tag.Append(line[i]);
            }

            Console.WriteLine(tag);
            return true;
        }
    }
}
