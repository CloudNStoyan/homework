using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained 
            //in another file test.txt. The result should be written in the file result.txt and the words should be sorted by the number 
            //of their occurrences in descending order. Handle all possible exceptions in your methods.

            string wordsPath = "words.txt";
            string textPath = "text.txt";
            string fileResultName = "result.txt";


            if (File.Exists(wordsPath) && File.Exists(textPath))
            {
                try
                {
                    string[] words = File.ReadAllText(wordsPath).Split(' ');
                    string[] textWords = File.ReadAllText(textPath).Split(' ');
                    List<string> result = new List<string>();

                    var wordOccurence = new Dictionary<string,int>();

                    foreach (string word in words)
                    {
                        wordOccurence.Add(word,0);
                    }

                    foreach (string textWord in textWords)
                    {
                        if (wordOccurence.ContainsKey(textWord))
                        {
                            wordOccurence[textWord]++;
                        }
                    }

                    foreach (var i in wordOccurence)
                    {
                        if (i.Value != 0)
                        {
                            result.Add(i.Value + " " + i.Key);
                        }
                    }
                    result.Sort();
                    var output = new StringBuilder();

                    foreach (string s in result)
                    {
                        output.AppendLine(s);
                    }

                    if (!File.Exists(fileResultName))
                    {
                        var fc = File.Create(fileResultName);
                        fc.Close();
                        File.WriteAllText(fileResultName,output.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"There is already file named {fileResultName}!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Good bye!");
                }
            }
            else
            {
                Console.WriteLine($"You are missing some of these files: {wordsPath} , {textPath}");
            }
        }
    }
}
