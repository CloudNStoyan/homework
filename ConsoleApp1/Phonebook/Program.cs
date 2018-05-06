using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static StringBuilder _output = new StringBuilder();
        static List<string> _phones = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    Console.WriteLine(_output);
                    break;
                }

                string tag = GetTag(line);
                string innerText = InnerText(line);

                switch (tag)
                {
                    case "AddPhone":
                        AddPhone(innerText);
                        break;
                    case "ChangePhone":
                        string oldNum = innerText.Split(',')[0];
                        string newNum = innerText.Split(',')[1];
                        ChangePhone(oldNum,newNum);
                        break;
                    case "List":
                        int start = int.Parse(innerText.Split(',')[0]);
                        int count = int.Parse(innerText.Split(',')[1]);
                        List(start,count);
                        break;
                    default:

                        break;
                }

            }
        }

        static void AddPhone(string number)
        {
            if (_phones.Any(s => s.ToLower().Contains(number.Split(',')[0].ToLower())))
            {
                int index = _phones.FindIndex(x => x.ToLower().StartsWith(number.Split(',')[0].ToLower()));
                string numbers = number.Split(',').Skip(1).Take(number.Split(',').Length - 1).ToString();
                Console.WriteLine(numbers);
                _phones[index] += ", " + number.Split('d');
                _output.AppendLine("Phone entry merged");
            }
            else
            {
                Console.WriteLine(number.Split(',')[0]);
                _phones.Add(number);
                _output.AppendLine("Phone entry created");
            }
            _phones.OrderBy(s => s.Split(',')[0].ToLower());
        }

        static void ChangePhone(string oldNumber, string newNumber)
        {
            int howMany = 0;
            for (int i = 0; i < _phones.Count; i++)
            {
                if (_phones[i].Contains(oldNumber))
                {
                    howMany++;
                    _phones[i] = _phones[i].Replace(oldNumber, newNumber);
                }
            }

            _output.AppendLine(howMany + " numbers changed");
        }

        static void List(int start, int count)
        {
            var build = new StringBuilder();

            for (int i = start; i < count; i++)
            {
                string rawText = _phones[i];
                var formatText = new StringBuilder();
                formatText.Append("[" + rawText.Split(',')[0] + ": ");
                for (int j = 1; j < rawText.Split(',').Length; j++)
                {
                    string numberRaw = rawText.Split(',')[j];
                    string number = Regex.Match(numberRaw, @"\d+").Value;
                    if (number.StartsWith("0"))
                    {
                        var regex = new Regex(Regex.Escape("0"));
                        number = regex.Replace(number, "+359", 1);
                    }

                    if (j == 1)
                    {
                        formatText.Append(number);
                    }
                    else
                    {
                        formatText.Append(", " + number);
                    }

                }

                build.Append(formatText);   
                if (i + 1 >= count)
                {
                    build.Append(']');
                }

            }

            _output.AppendLine(build.ToString());
        }

        static string GetTag(string text)
        {
            var build = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    return build.ToString();
                }

                build.Append(text[i]);
            }

            return "FAIL";
        }

        static string InnerText(string text)
        {
            var build = new StringBuilder();
            bool inText = false;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (inText && i + 1 < text.Length)
                {
                    build.Append(c);
                }

                if (c == '(')
                {
                    inText = true;
                }
            }

            return build.ToString();
        }

    }
}
