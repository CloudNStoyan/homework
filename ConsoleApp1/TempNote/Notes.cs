using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempNote
{
    class Notes
    {
        private Dictionary<string, string> NotesDictionary = new Dictionary<string, string>();


        public void AddNote(string context)
        {
            string key = context.Split(' ')[0];
            string value = string.Join(" ", context.Split(' ').Skip(1));

            this.NotesDictionary.Add(key, value);
        }

        public void RemoveNote(string context)
        {
            string key = context;
            this.NotesDictionary.Remove(key);
        }

        public void EditNote(string context)
        {
            string key = context.Split(' ')[0];
            string newValue = string.Join(" ", context.Split(' ').Skip(1));

            this.NotesDictionary[key] = newValue;
        }

        public string ViewNote(string context)
        {
            string key = context;

            return this.NotesDictionary.ContainsKey(key) ? this.NotesDictionary[key] : string.Empty;
        }
    }
}
