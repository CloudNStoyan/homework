using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and prints on the console its odd lines.

            string path = @"text.txt";
            var encoding = Encoding.UTF8;
            if (File.Exists(path))
            {
                using (var stream = new StreamReader(path, encoding))
                {
                    try
                    {
                        List<string> oddLines = new List<string>();
                        string line = stream.ReadLine();
                        int lineNumber = 1;
                        while (line != null)
                        {
                            if (lineNumber % 2 != 0)
                            {
                                oddLines.Add(line);
                            }

                            lineNumber++;
                            line = stream.ReadLine();
                        }

                        foreach (string oddLine in oddLines)
                        {
                            Console.WriteLine(oddLine);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
            else
            {
                Console.WriteLine($"File {path} doesn't exist!");
            }
        }
    }
}
