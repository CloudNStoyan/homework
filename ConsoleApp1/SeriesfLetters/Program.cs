using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
            string text = Console.ReadLine();

            Console.WriteLine(Regex.Replace(text, @"(\w)\1+", "$1"));
        }
    }
}
