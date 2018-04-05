using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to 
            //another text file.

            string path = "text.txt";
            var encoding = Encoding.UTF8;
            string text = "";
            List<string> lines = new List<string>();

            if (File.Exists(path))
            {
                using (var stream = new StreamReader(path,encoding))
                {
                    try
                    {
                        string line = stream.ReadLine();
                        int count = 1;
                        
                        while (line != null)
                        {
                            lines.Add(count + ". " + line);
                            count++;
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
                Console.WriteLine($"There is a file already with that name!");
            }

            string fileName = "numeredText.txt";
            if (!File.Exists(fileName))
            {
                var fs = File.Create(fileName);
                using (var stream = new StreamWriter(fs,encoding))
                {
                    try
                    {
                        foreach (string line in lines)
                        {
                            stream.WriteLine(line);
                            fs.Flush();
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
                Console.WriteLine($"There is already file {fileName} in this directory!");
            }
        }
    }
}
