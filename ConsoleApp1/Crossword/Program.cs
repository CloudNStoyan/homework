using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossword
{
    class Program
    {
        public static List<string> _lines = new List<string>();
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() + "");

            for (int i = 0; i < n * 2; i++)
            {
                _lines.Add( Console.ReadLine());
            }

            var crosswords = GetAllCollWords(n);

            for (int i = 0; i < _lines.Count; i++)
            {
                if (FindExpectThis(_lines[i], i))
                {
                    crosswords.Add(_lines[i]);
                }
            }

            Console.Clear();

            if (crosswords.Count > 0)
            {
                foreach (var str in crosswords)
                {
                    Console.WriteLine(str);
                }
            }
            else
            {
                Console.WriteLine("NO SOLUTION!");
            }
        }

        static List<string> GetAllCollWords(int n)
        {
            int length = n;

            var collwords = new List<string>();

            int increase = 0;
            while (length < (n - 1 ) * 2) 
            {
                for (int charIndex = 0; charIndex < n; charIndex++)
                {
                    var word = new StringBuilder();
                    for (int lineIndex = 0 + increase; lineIndex < length; lineIndex++)
                    {
                        word.Append(_lines[lineIndex][charIndex]);
                    }

                    if (ThereIsWord(word.ToString()))
                    {

                        collwords.Add(word.ToString());
                    }
                }

                length++;
                increase++;
            }

            return collwords;
        }

        static bool ThereIsWord(string word)
        {
            foreach (string line in _lines)
            {
                if (line == word)
                {
                    return true;
                }
            }

            return false;
        }

        static bool FindExpectThis(string line, int index)
        {
            for (int i = 0; i < _lines.Count; i++)
            {
                if (i != index && _lines[i] == line)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
