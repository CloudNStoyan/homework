using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that deletes from a text file all words that start with the prefix test. Words contain only the symbols 0…9, 
            //a…z, A…Z, _.

            StringBuilder output = new StringBuilder();
            string path = "text.txt";

            if (File.Exists(path))
            {
                string[] words = File.ReadAllText(path).Split(' ');
                foreach (string word in words)
                {
                    if (!word.Contains("test"))
                    {
                        output.Append(" " + word);
                    }
                }

                File.WriteAllText(path,output.ToString().Trim());
            }
            else
            {
                Console.WriteLine($"There is no file {path} in this directory!");
            }
        }
    }
}
