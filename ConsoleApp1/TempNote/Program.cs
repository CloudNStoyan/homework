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
        private static Notes NoteService;
        private static PrintService PrintService;

        static void Main(string[] args)
        {
            NoteService = new Notes();
            PrintService = new PrintService();

            while (true)
            {
                string command = Console.ReadLine();
                if (command != null)
                {
                    HandleCommand(command);
                }
                else
                {
                    PrintService.Print("Command wasn't detected!");
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
                    NoteService.AddNote(context);
                    PrintService.Print("Note added!");
                    break;
                case "view":
                    string note = NoteService.ViewNote(context);
                    PrintService.Print(note != string.Empty ? note : "No note found!");

                    break;
                case "remove":
                    NoteService.RemoveNote(context);
                    PrintService.Print("Note removed!");
                    break;
                case "edit":
                    NoteService.EditNote(context);
                    PrintService.Print("Note edited!");
                    break;
                case "help":
                    PrintService.PrintHelp();
                    break;
                case "clear":
                    Clear();
                    break;
                default:
                    PrintService.Print("Command wasn't detected!");
                    break;
            }
        }

       

        private static void Clear()
        {
            Console.Clear();
        }
    }
}
