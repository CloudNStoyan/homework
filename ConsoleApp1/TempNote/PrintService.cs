using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempNote
{
    class PrintService
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Print(string[] lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

	public void Clear()
        {
            Console.Clear();
        }

        public void PrintHelp()
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
    }
}
