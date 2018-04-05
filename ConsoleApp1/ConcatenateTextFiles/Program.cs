using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConcatenateTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that concatenates two text files into another text file.

            string theFirstFilePath = "text1.txt";
            string theSecondFilePath = "text2.txt";
            string fileName = "concatenatedText.txt";
            var encoding = Encoding.UTF8;
            string concatenatedText = "";
            if (File.Exists(theFirstFilePath))
            {
                using (var stream = new StreamReader(theFirstFilePath,encoding))
                {
                    try
                    {
                        string text = stream.ReadToEnd();
                        concatenatedText += text + "\n";
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
                Console.WriteLine($"The file at {theFirstFilePath} doesn't exist!");
            }

            if (File.Exists(theSecondFilePath))
            {
                using (var stream = new StreamReader(theSecondFilePath,encoding)) 
                {
                    try
                    {
                        string text = stream.ReadToEnd();
                        concatenatedText += text;
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
                Console.WriteLine($"The file at {theSecondFilePath} doesn't exist!");
            }

            if (!File.Exists(fileName))
            {
                var fs = File.Create(fileName);
                using (var stream = new StreamWriter(fs, encoding))
                {
                    try
                    {
                        stream.WriteLine(concatenatedText);
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
        }
    }
}
