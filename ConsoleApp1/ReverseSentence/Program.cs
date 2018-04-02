using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reverses the words in a given sentence.

            string[] sentences = Console.ReadLine().Split(' ');
            StringBuilder output = new StringBuilder();

            for (int i = sentences.Length - 1; i >= 0; i--)
            {
                output.Append(sentences[i] + " ");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
