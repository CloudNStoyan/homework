using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace ReadFileContents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on 
            //the console. Find in MSDN how to use System.IO.File.ReadAllText(...). Be sure to catch all possible exceptions and print 
            //user-friendly error messages.
            string path = Console.ReadLine();
            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You probably entered unsupported argument!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path of the file is too long!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory you entered was not found!");
            }
            catch (IOException)
            {
                Console.WriteLine("This file probably doesn't exist!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The file you try to open is read-only or you dont have the required permission!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in invalid format!");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have the required permission to open this file!");
            }
        }
    }
}
