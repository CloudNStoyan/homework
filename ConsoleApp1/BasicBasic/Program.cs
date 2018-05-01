using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicBasic
{
    class Program
    {
        static int v, w, x, y, z;
        static Dictionary<int,string> code = new Dictionary<int, string>();
        static StringBuilder output = new StringBuilder();

        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                line = regex.Replace(line, " ");
                if (line == "RUN")
                {
                    Console.WriteLine(output.ToString().Trim());
                    break;
                }

                if (line.Split(' ')[1] == "STOP")
                {
                    while (true)
                    {
                        line = Console.ReadLine();
                        if (line == "RUN")
                        {
                            Console.WriteLine(output.ToString().Trim());
                            break;
                        }
                    }

                    break;
                }

                int lineNumber = int.Parse(Regex.Match(line, @"\d+").Value);

                regex = new Regex(Regex.Escape(lineNumber.ToString()));
                line = regex.Replace(line, "", 1).Trim();
                code.Add(lineNumber,line);

                GiveCommand(line);
            }
        }

        static void GiveCommand(string line)
        {
            if (line.Contains("IF"))
            {
                Run("IF",line);
            } else if (line.Contains("+"))
            {
                Run("ADD", line);
            } else if (line.Contains("-"))
            {
                if (line.Split('=')[1].Split('-')[0] == "")
                {
                    Run("ASSIGN",line);
                }
                else
                {
                    Run("EXTRACT",line);
                }
            } else if (line.Contains("="))
            {
                Run("ASSIGN",line);
            } else if (line.Contains("GOTO"))
            {
                Run("GOTO",line);
            } else if (line.Contains("CLS"))
            {
                Run("CLS",line);
            } else if (line.Contains("PRINT"))
            {
                Run("PRINT", line);
            }
        }

        static void Run(string command,string line)
        {
            switch (command)
            {
                case "IF":
                    If(line);
                    break;
                case "ADD":
                    Add(line);
                    break;
                case "EXTRACT":
                    Extract(line);
                    break;
                case "ASSIGN":
                    Assign(line);
                    break;
                case "GOTO":
                    Goto(line);
                    break;
                case "CLS":
                    output.Clear();
                    break;
                case "PRINT":
                    Print(line);
                    break;
            }
        }

        static void If(string line)
        {
            int startIndex = line.IndexOf("IF") + 2;
            int length = line.IndexOf("THEN") - 2;

            string condition = line.Substring(startIndex, length).Trim();
            string cmd = line.Split(new[] { "THEN" }, StringSplitOptions.None)[1];

            if (Condition(condition))
            {
                GiveCommand(cmd);
            }
        }

        static void Add(string line)
        {
            char variable = line.Split('=')[0][0];

            string aHold = line.Split('=')[1].Split('+')[0].Trim();
            string bHold = line.Split('=')[1].Split('+')[1].Trim();

            int a = IsDigitsOnly(aHold) ? int.Parse(aHold) : GetVariableValue(aHold[0]);
            int b = IsDigitsOnly(bHold) ? int.Parse(bHold) : GetVariableValue(bHold[0]);

            SetValueTo((a + b),variable);
        }

        static void Extract(string line)
        {
            char variable = line.Split('=')[0][0];

            string aHold = line.Split('=')[1].Split('-')[0].Trim();
            string bHold = line.Split('=')[1].Split('-')[1].Trim();

            int a = IsDigitsOnly(aHold) ? int.Parse(aHold) : GetVariableValue(aHold[0]);
            int b = IsDigitsOnly(bHold) ? int.Parse(bHold) : GetVariableValue(bHold[0]);

            SetValueTo((a - b), variable);
        }

        static void Assign(string line)
        {
            char variable = line.Split('=')[0].Trim()[0];
            int number = int.Parse(line.Split('=')[1].Trim());
            SetValueTo(number,variable);
        }

        static void Goto(string line)
        {
            int index = int.Parse(line.Split(new[] { "GOTO" }, StringSplitOptions.None)[1].Trim());
            var keyList = code.Keys.ToList();
            var valueList = code.Values.ToList();
            int from = keyList.IndexOf(index);
            for (int i = from; i < keyList.Count; i++)
            {
                GiveCommand(valueList[i]);
            }
        }

        static void Print(string line)
        {
            string message = line.Split(new[] {"PRINT"}, StringSplitOptions.None)[1].Trim();
            string outputValue = "";
            switch (message)
            {
                case "V":
                    outputValue = GetVariableValue('V').ToString();
                    break;
                case "W":
                    outputValue = GetVariableValue('W').ToString();
                    break;
                case "X":
                    outputValue = GetVariableValue('X').ToString();
                    break;
                case "Y":
                    outputValue = GetVariableValue('Y').ToString();
                    break;
                case "Z":
                    outputValue = GetVariableValue('Z').ToString();
                    break;
                default:
                    break;
            }

            output.AppendLine(outputValue);
        }

        static bool Condition(string condition)
        {
            if (condition.Contains('>'))
            {
                var numbers = condition.Split('>');
                numbers[0] = numbers[0].Trim();
                numbers[1] = numbers[1].Trim();
                int a = IsDigitsOnly(numbers[0]) ? int.Parse(numbers[0]) : GetVariableValue(numbers[0][0]);
                int b = IsDigitsOnly(numbers[1]) ? int.Parse(numbers[1]) : GetVariableValue(numbers[1][0]);

                return a > b;
            }
            if (condition.Contains('<'))
            {
                var numbers = condition.Split('<');
                numbers[0] = numbers[0].Trim();
                numbers[1] = numbers[1].Trim();
                int a = IsDigitsOnly(numbers[0]) ? int.Parse(numbers[0]) : GetVariableValue(numbers[0][0]);
                int b = IsDigitsOnly(numbers[1]) ? int.Parse(numbers[1]) : GetVariableValue(numbers[1][0]);

                return a < b;
            }
            else
            {
                var numbers = condition.Split('=');
                numbers[0] = numbers[0].Trim();
                numbers[1] = numbers[1].Trim();
                int a = IsDigitsOnly(numbers[0]) ? int.Parse(numbers[0]) : GetVariableValue(numbers[0][0]);
                int b = IsDigitsOnly(numbers[1]) ? int.Parse(numbers[1]) : GetVariableValue(numbers[1][0]);

                return a == b;
            }
        }



        static int GetVariableValue(char c)
        {
            switch (c)
            {
                case 'V':
                    return v;
                case 'W':
                    return w;
                case 'X':
                    return x;
                case 'Y':
                    return y;
                case 'Z':
                    return z;
                default:
                    return -1;
            }
        }

        static void SetValueTo(int n,char c)
        {
            switch (c)
            {
                case 'V':
                    v = n;
                    break;
                case 'W':
                    w = n;
                    break;
                case 'X':
                    x = n;
                    break;
                case 'Y':
                    y = n;
                    break;
                case 'Z':
                    z = n;
                    break;
                default:
                    break;
            }
        }

        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}