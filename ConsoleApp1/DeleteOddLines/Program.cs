using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that deletes from given text file all odd lines. The result should be in the same file.

            StringBuilder result = new StringBuilder();
            string path = "text.txt";
            var encoding = Encoding.UTF8;

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
                            if (count % 2 == 0)
                            {
                                result.AppendLine(line);
                            }
                            line = stream.ReadLine();
                            count++;
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

                File.WriteAllText(path,result.ToString());
            }
            else
            {
                Console.WriteLine($"There is no file {path} in this directory!");
            }
        }
    }
}
