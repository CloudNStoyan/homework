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
                _lines[i] = Console.ReadLine();
            }

            var crosswords = new List<string>();

            for (int i = 0; i < _lines.Count; i++)
            {
                if (FindExpectThis(_lines[i], i))
                {
                    crosswords.Add(_lines[i]);
                }
            }
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
