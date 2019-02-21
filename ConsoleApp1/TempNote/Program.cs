using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TempNote
{
    class Program
    {
        private static Dictionary<string, string> Notes = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                HandleCommand(command);
            }
        }

        private static void HandleCommand(string commandGiven)
        {
            // Cleaning repetetive spaces
            commandGiven = Regex.Replace(commandGiven, @"\s+", " ");


            string[] splitCommnad = commandGiven.Split(' ');

            string command = splitCommnad[0];

            string context = string.Join(" ", splitCommnad.Skip(1));

            switch (command)
            {
                case "add":
                    AddNote(context);
                    Print("Note added!");
                    break;
                case "view":
                    string note = ViewNote(context);
                    Print(note);
                    break;
                case "remove":
                    RemoveNote(context);
                    Print("Note removed!");
                    break;
                case "edit":
                    EditNote(context);
                    Print("Note edited!");
                    break;
                default:
                    Print("Command wasn't detected!");
                    break;
            }
        }

        private static void Print(string text)
        {
            Console.WriteLine(text);
        }


        private static void AddNote(string context)
        {
            string key = context.Split(' ')[0];
            string value = string.Join(" ", context.Split(' ').Skip(1));

            Notes.Add(key, value);
        }

        private static void RemoveNote(string context)
        {
            string key = context;
            Notes.Remove(key);
        }

        private static void EditNote(string context)
        {
            string key = context.Split(' ')[0];
            string newValue = string.Join(" ", context.Split(' ').Skip(1));

            Notes[key] = newValue;
        }

        private static string ViewNote(string context)
        {
            string key = context;
            return Notes[key];
        }
    }
}
