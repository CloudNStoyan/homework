using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalAreaSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file containing a square matrix of numbers. Find an area of size 2 x 2 in the matrix, with a 
            //maximal sum of its elements.

            string path = "../../text.txt";
            var encoding = Encoding.UTF8;

            List<string> text = new List<string>();
            if (File.Exists(path))
            {
                using (var stream = new StreamReader(path, encoding))
                {
                    try
                    {
                        string line = stream.ReadLine();
                        while (line != null)
                        {
                            text.Add(line);
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
                Console.WriteLine($"There is no file text.txt in this directory!");
            }

            int bestArea = 0;

            string[][] arr = new string[int.Parse(text[0])][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = text[i + 1].Split(' ');
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr[i].Length - 1; j++)
                {
                    int currentArea = int.Parse(arr[i][j]) + int.Parse(arr[i][j + 1]) + int.Parse(arr[i + 1][j]) + int.Parse(arr[i + 1][j + 1]);
                    if (currentArea > bestArea)
                    {
                        bestArea = currentArea;
                    }
                }
            }

            string newFilePath = "../../result.txt";

            if (!File.Exists(newFilePath))
            {
                try
                {
                    var fc = File.Create(newFilePath);
                    fc.Close();
                    File.WriteAllText(newFilePath, bestArea.ToString());
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
                Console.WriteLine($"There is already file {newFilePath}!");
            }
        }
    }
}
