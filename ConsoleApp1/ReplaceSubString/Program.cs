using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file. Ensure it will 
            //work with large files (e.g. 100 MB).

            string path = "text.txt";
            string text = File.ReadAllText(path);
            text = text.Replace("start", "finish");
            File.WriteAllText(path,text);
        }
    }
}
