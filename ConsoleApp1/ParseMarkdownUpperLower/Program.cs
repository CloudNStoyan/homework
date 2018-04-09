using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseMarkdownUpperLower
{
    class Program
    {
        static void Main(string[] args)
        {
            // all text between ** ** should be uppercase
            // all text between `` should be lowercase
            // all text between _ _ should be mixed case

            var markdown = @"# String processing tasks
- **Manipulating strings - comparing, concatanating, searching, extracting, splitting**
  - `Comparison`
    - What is lexicographic comparison
    - Brief showcase of string.Compare
    - _Live demo_: Compare strings by given priority of letters
  - `Concatanating`
    - Brief showcase Concat
  - `Searching`
    - _Live demo_: Find all occurences of a given substring
  - `Substring and extracting strings`
    - Brief showcase substring method
    - _Live demo_: Extract all comments from code
  - `Splitting`
    - Brief showcase split method
    - _Live demo_: Read input for a problem
    - _Live demo_: Extract comments from code
    - _Live demo_: Count occurences of a string
- **Other operations**
  - `Replacing substrings`
    - Brief showcase replace method
    - _Live demo_: Sanitize input against XSS
    - _Live demo_: Censorship
  - `Case transformations`
    - Brief showcase upper and lowercase methods
    - _Live demo_: Parse md-like thing
  - `Trimming`
    - _Live demo_: Remove leading zeros from a number
    - _Live demo_: Trim spaces from html
    - Bonus: Padding
      - Showcase PadLeft and PadRight
- **Building and Modifying strings**
  - `StringBuilder`
    - _Live demo_: Compress a string
    - _Live demo_: Decompress a string
- **Formatting strings**
  - `String interpolation`
    - Brief showcase
  - `String.Format`
    - Brief showcase
- **Cultures and Culture-Sensitive Formatting**
  - **TODO**
  - `Parsing Numbers and Dates`
    - _Live demo_: Parse a date by hand by a given format
    - _Live demo_: Compare custom parse to buil-in int.Parse  ";

            string[] lines = markdown.Split(new[] { Environment.NewLine },
                StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (line.Contains("**"))
                {
                    Console.WriteLine(BetweenWords(line,"**","**").ToUpper());
                } else if (line.Contains('`'))
                {
                    Console.WriteLine(BetweenChars(line,'`','`').ToLower());
                } else if (line.Contains("_"))
                {
                    var str = BetweenChars(line, '_', '_');
                    Console.WriteLine(ToMixedCase(str));
                }
                else
                {
                    Console.WriteLine(line);
                }
            }
        }

        static string BetweenWords(string str, string firstString, string lastString)
        {
            var inTag = false;
            var result = new StringBuilder();
            for (int i = 1; i < str.Length; i++)
            {   
                if (i + 1 < str.Length && i != 1 && str[i] == lastString[0] && str[i + 1] == lastString[1])
                {
                    inTag = false;
                }
                if (inTag)
                {
                    result.Append(str[i]);
                }
                if (str[i - 1] == firstString[0] && str[i] == firstString[1])
                {
                    inTag = true;
                }
            }

            return result.ToString();
        }

        static string BetweenChars(string str, char firstChar, char lastChar)
        {
            var inTag = false;
            var result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == lastChar)
                {
                    inTag = false;
                }

                if (inTag)
                {
                    result.Append(str[i]);
                }

                if (str[i] == firstChar)
                {
                    inTag = true;
                }
            }

            return result.ToString();
        }

        static string ToMixedCase(string str)
        {
            var result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    result.Append(str[i].ToString().ToLower());
                }
            }

            return result.ToString();
        }
    }
}
