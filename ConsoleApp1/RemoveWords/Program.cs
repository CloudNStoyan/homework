using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

            var result = new StringBuilder();
            string wordsToRemove = "words.txt";
            string textPath = "text.txt";

            if (File.Exists(wordsToRemove) && File.Exists(textPath))
            {
                try
                {
                    string[] removingWords = File.ReadAllText(wordsToRemove).Split(' ');
                    string[] wordsInText = File.ReadAllText(textPath).Split(' ');
                    foreach (string word in wordsInText)
                    {
                        bool illegable = true;
                        for (int i = 0; i < removingWords.Length; i++)
                        {
                            if (word == removingWords[i])
                            {
                                illegable = false;
                            }
                        }

                        if (illegable)
                        {
                            result.Append(" " + word);
                        }
                    }

                    File.WriteAllText(textPath, result.ToString().Trim());
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
                Console.WriteLine($"There is missing file/s in this directory check if you have all these files: {textPath} , {wordsToRemove}");
            }
        }
    }
}
