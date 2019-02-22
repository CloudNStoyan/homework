using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
                if (command != null)
                {
                    HandleCommand(command);
                }
                else
                {
                    Print("Command wasn't detected!");
                }
            }
        }

        private static void HandleCommand(string commandGiven)
        {
            // Cleaning repetetive spaces
            commandGiven = Regex.Replace(commandGiven, @"\s+", " ");


            string[] splitCommnad = commandGiven.Split(' ');

            string command = splitCommnad[0].ToLower();

            string context = string.Join(" ", splitCommnad.Skip(1));

            switch (command)
            {
                case "add":
                    AddNote(context);
                    Print("Note added!");
                    break;
                case "view":
                    string note = ViewNote(context);
                    Print(note != string.Empty ? note : "No note found!");

                    break;
                case "remove":
                    RemoveNote(context);
                    Print("Note removed!");
                    break;
                case "edit":
                    EditNote(context);
                    Print("Note edited!");
                    break;
                case "help":
                    PrintHelp();
                    break;
                case "clear":
                    Clear();
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

        private static void Print(string[] lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
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

            return Notes.ContainsKey(key) ? Notes[key] : string.Empty;
        }

        private static void PrintHelp()
        {
            string example = "EXAMPLE: ";

            string addNoteHelp = "To create new note:";
            string addNoteExample =
                "add [name of the note (without spaces)] [value of the note (spaces may be used)]";
            string addNoteRealExample = example + "add foo bar bar bar bar";

            string viewNoteHelp = "To view already declared note:";
            string viewNoteExample = "view [name of the note (without spaces)]";
            string viewNoteRealExample = example + "view foo";

            string editNoteHelp = "To edit already declared note:";
            string editNoteExample =
                "edit [name of the note (without spaces)] [new value of the note (spaces may be used)]";
            string editNoteRealExample = example + "edit foo bar ? yep bars!";

            string removeNoteHelp = "To remove already declared note:";
            string removeNoteExample = "remove [name of the note (without spaces)]";
            string removeNoteRealExample = example + "remove foo";

            Print(new[]
            {
                addNoteHelp, addNoteExample, addNoteRealExample, viewNoteHelp, viewNoteExample, viewNoteRealExample,
                editNoteHelp, editNoteExample, editNoteRealExample, removeNoteHelp, removeNoteExample, removeNoteRealExample
            });
        }

        private static void Clear()
        {
            Console.Clear();
        }
    }
}
