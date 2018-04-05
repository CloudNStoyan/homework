using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that compares two text files line by line and prints the number of lines that are the same and the number of 
            //lines that are different. Assume the files have equal number of lines.

            List<string> textOne = new List<string>();
            List<string> textTwo = new List<string>();
            List<string> different = new List<string>();
            List<string> same = new List<string>();

            string firstFilePath = "text1.txt";
            string secondFilePath = "text2.txt";
            var encoding = Encoding.UTF8;

            if (File.Exists(firstFilePath))
            {
                using (var stream = new StreamReader(firstFilePath,encoding))
                {
                    try
                    {
                        string line = stream.ReadLine();

                        while (line != null)
                        {
                            textOne.Add(line);
                            line = stream.ReadLine();
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
                Console.WriteLine($"File: {firstFilePath} doesn't exist!");
                return;
            }

            if (File.Exists(secondFilePath))
            {
                using (var stream = new StreamReader(secondFilePath, encoding))
                {
                    try
                    {
                        string line = stream.ReadLine();

                        while (line != null)
                        {
                            textTwo.Add(line);
                            line = stream.ReadLine();
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
                Console.WriteLine($"File: {secondFilePath} doesn't exist!");
                return;
            }

            for (int i = 0; i < textOne.Count; i++)
            {
                if (textOne[i] == textTwo[i])
                {
                    same.Add(textOne[i]);
                }
                else
                {
                    different.Add(textOne[i] + $"  from {firstFilePath}");
                    different.Add(textTwo[i] + $"  from {secondFilePath}");
                }
            }

            Console.WriteLine("Same lines are :");
            foreach (string line in same)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Different lines are :");
            foreach (string line in different)
            {
                Console.WriteLine(line);
            }
        }
    }
}
