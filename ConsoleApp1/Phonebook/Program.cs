using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static StringBuilder _output = new StringBuilder();
        static Dictionary<string,string> _phoneDictionary = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    Console.Clear();
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
                        ChangePhone(innerText);
                        break;
                    case "List":
                        List(innerText);
                        break;
                    default:

                        break;
                }

            }
        }

        static void AddPhone(string input)
        {
            var inputWords = input.Split(',');
            string name = inputWords[0];
            var numbers = _phoneDictionary.ContainsKey(name.ToLower()) ? _phoneDictionary[name.ToLower()].Split(':')[1].Split(',').ToList() : new List<string>();


            if (!_phoneDictionary.ContainsKey(name.ToLower()))
            {

                var build = new StringBuilder();

                build.Append('[' + name + ": ");

                for (int i = 1; i < inputWords.Length; i++)
                {
                    string numberRaw = inputWords[i];
                    string myNum = new String(numberRaw.Where(Char.IsDigit).ToArray());
                    var regex = new Regex(Regex.Escape("0"));
                    myNum = regex.Replace(myNum, "359", 1);
                    myNum = "+" + myNum;

                    if (i > 1)
                    {
                        build.Append(", " + myNum);
                    }
                    else
                    {
                        build.Append(myNum);
                    }
                }

                numbers.Add(build.ToString());
                numbers = CleanEmpty(numbers);
                numbers.Sort();

                string nums = CombineList(numbers, ", ");
                _phoneDictionary.Add(name.ToLower(), nums);

                _output.AppendLine("Phone entry created");
            }
            else
            {
                for (int i = 1; i < inputWords.Length; i++)
                {
                    string numberRaw = inputWords[i];
                    string myNum = new String(numberRaw.Where(Char.IsDigit).ToArray());
                    var regex = new Regex(Regex.Escape("0"));
                    myNum = regex.Replace(myNum, "359", 1);
                    myNum = "+" + myNum;
                    if (!_phoneDictionary[name.ToLower()].Contains(myNum))
                    {
                        numbers.Add(myNum);
                    }
                }

                numbers = CleanEmpty(numbers);
                numbers.Sort();
                string nums = CombineList(numbers, ", ");
                _phoneDictionary[name.ToLower()] = _phoneDictionary[name.ToLower()].Split(':')[0] + ": " + nums;

                _output.AppendLine("Phone entry merged");
            }
        }

        static void ChangePhone(string input)
        {
            int howMany = 0;

            var regex = new Regex(Regex.Escape("0"));

            string oldNum = new String(input.Split(',')[0].Where(Char.IsDigit).ToArray());
            oldNum = regex.Replace(oldNum, "359", 1);
            oldNum = "+" + oldNum;

            string newNum = new String(input.Split(',')[1].Where(Char.IsDigit).ToArray());
            newNum = regex.Replace(newNum, "359", 1);
            newNum = "+" + newNum;

            var keys = _phoneDictionary.Keys.ToList();
            var values = _phoneDictionary.Values.ToList();

            for (int i = 0; i < keys.Count; i++)
            {
                if (values[i].Contains(oldNum) && !values[i].Contains(newNum))
                {
                    _phoneDictionary[keys[i]] = _phoneDictionary[keys[i]].Replace(oldNum, newNum);
                    howMany++;
                }
            }
            

            _output.AppendLine(howMany + " numbers changed");

        }

        static void List(string input)
        {
            var phonebook = _phoneDictionary.Keys.ToList();
            phonebook.Sort();

            int start = int.Parse(input.Split(',')[0]);
            int count = int.Parse(input.Split(',')[1]);

            if (start < 0 || start + count > phonebook.Count)
            {
                _output.AppendLine("Invalid range");
                return;
            }

            for (int i = start; i < start + count; i++)
            {
                _output.AppendLine(_phoneDictionary[phonebook[i]].Remove(_phoneDictionary[phonebook[i]].Length - 2) + "]");
            }
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

        static string CombineList(List<string> list, string between)
        {
            var build = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                build.Append(list[i] + between);
            }

            return build.ToString();
        }

        static List<string> CleanEmpty(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "" || list[i] == " " || list[i] == String.Empty)
                {
                    list.RemoveAt(i);
                }
                else
                {
                    list[i] = list[i].Trim();
                }
            }

            return list.Distinct().ToList();
        }

        static List<string> Sort(List<string> list)
        {
            for (int i = 0; i < 1; i++)
            {
                
            }
            return new List<string>();
        }
    }
}
