using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceWholeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modify the solution of the previous problem to replace only whole words (not strings).
            //Previous problem:
            //Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file. Ensure it will 
            //work with large files (e.g. 100 MB).

            string path = "text.txt";
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                string pattern = @"\bstart\b";
                string replace = "finish";
                text = Regex.Replace(text, pattern, replace);
                File.WriteAllText(path, text);
            }
            else
            {
                Console.WriteLine($"This file {path} doesn't exist in this directory!");
            }

        }
    }
}
