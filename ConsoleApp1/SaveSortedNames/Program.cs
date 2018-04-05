using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveSortedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
            List<string> names = new List<string>();

            string path = "names.txt";
            var encoding = Encoding.UTF8;

            if (File.Exists(path))
            {
                using (var stream = new StreamReader(path,encoding))
                {
                    try
                    {
                        string line = stream.ReadLine();

                        while (line != null)
                        {
                            names.Add(line);
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
                Console.WriteLine($"There is no file with names {path} in this directory!");
            }

            names.Sort();

            string fileName = "sortedNames.txt";

            if (!File.Exists(fileName))
            {
                var fs = File.Create(fileName);

                using (var stream = new StreamWriter(fs,encoding))
                {
                    try
                    {
                        foreach (string name in names)
                        {
                            stream.WriteLine(name);
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
                Console.WriteLine($"There is an existing file named {fileName}!");
            }
        }
    }
}
