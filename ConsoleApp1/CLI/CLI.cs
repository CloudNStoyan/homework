using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            //For this task, use only the command line and a text editor. Create a folder(name it however you want), navigate into it and create a CLI.cs file.
            // Open the CLI.cs file from the command line with whatever text editor you're comfortable with. Write a program that, when compiled to an executable,
            // is run from the command line. Also, you should pass parameters(numbers) to it. Your executable should be called like that:
            int result = 0;
            for (int i = 0; i < args.Length; i++)
            {
                result += int.Parse(args[i]);
            }
            Console.WriteLine(result);
        }
    }
}
