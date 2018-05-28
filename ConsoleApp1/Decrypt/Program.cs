using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Decrypt
{
    class Program
    {
        private static Dictionary<char, int> CharToCode = new Dictionary<char, int>
        {
            {'A', 0},
            {'B', 1},
            {'C', 2},
            {'D', 3},
            {'E', 4},
            {'F', 5},
            {'G', 6},
            {'H', 7},
            {'I', 8},
            {'J', 9},
            {'K', 10},
            {'L', 11},
            {'M', 12},
            {'N', 13},
            {'O', 14},
            {'P', 15},
            {'Q', 16},
            {'R', 17},
            {'S', 18},
            {'T', 19},
            {'U', 20},
            {'V', 21},
            {'W', 22},
            {'X', 23},
            {'Y', 24},
            {'Z', 25}
        };
        private static Dictionary<int, char> CodeToChar = new Dictionary<int, char>
        {
            {0,'A'},
            {1,'B'},
            {2,'C'},
            {3,'D'},
            {4,'E'},
            {5,'F'},
            {6,'G'},
            {7,'H'},
            {8,'I'},
            {9,'J'},
            {10,'K'},
            {11,'L'},
            {12,'M'},
            {13,'N'},
            {14,'O'},
            {15,'P'},
            {16,'Q'},
            {17,'R'},
            {18,'S'},
            {19,'T'},
            {20,'U'},
            {21,'V'},
            {22,'W'},
            {23,'X'},
            {24,'Y'},
            {25,'Z'}
        };

        static string GetCypher(string encrypted)
        {
            var output = new StringBuilder();
            string[] numbers = Regex.Split(encrypted, @"\D+");
            int cypherLength = int.Parse(numbers[numbers.Length - 1]);
            int startIndex = encrypted.Length - cypherLength - numbers[numbers.Length - 1].Length;
            string cypher = encrypted.Substring(startIndex, cypherLength);
            output.Append(cypher);
            return output.ToString();
        }

        static string GetMessage(string encrypted, int length)
        {
            var output = new StringBuilder();
            for (int i = 0; i < encrypted.Length - length - 1; i++)
            {
                if (!char.IsDigit(encrypted[i]))
                {
                    output.Append(encrypted[i]);
                }
            }

            return output.ToString();
        }

        static void Main(string[] args)
        {
            string input = Decode(Console.ReadLine());
            string cypher = GetCypher(input);
            string message = GetMessage(input, cypher.Length);
            Console.WriteLine(Decrypt(message, cypher));
        }


        static string Encode(string text)
        {
            var builder = new StringBuilder();
            int count = 1;
            char holder = ' ';
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i - 1] == text[i])
                {
                    count++;
                    holder = text[i];
                }
                else
                {
                    if (count > 2)
                    {
                        builder.Append(holder + "" + count);
                    }
                    else
                    {
                        builder.Append(text[i - 1]);
                    }
                    count = 1;
                }

                if (i == text.Length - 1 && count > 2)
                {
                    builder.Append(holder + "" + count);
                }
                else if (i == text.Length - 1 && count == 2)
                {
                    builder.Append(text[i] + "" + text[i]);
                }
                else if (i == text.Length - 1)
                {
                    builder.Append(text[i]);
                }
            }
            return builder.ToString();
        }


        static string Decode(string text)
        {
            string[] numbers = Regex.Split(text, @"\D+");
            var holder = new StringBuilder();
            for (int i = 0; i < text.Length - numbers[numbers.Length - 1].Length; i++)
            {
                holder.Append(text[i]);
            }

            text = holder.ToString();

            var builder = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    int j = i;
                    string number = "";
                    while (char.IsDigit(text[j]))
                    {
                        if (j >= text.Length)
                        {
                            break;
                        }

                        number += text[j];
                        j++;
                    }

                    char c = builder[builder.Length - 1];
                    builder.Remove(builder.Length - 1, 1);
                    int times = (number != "") ? int.Parse(number) : 0;
                    for (int k = 0; k < times; k++)
                    {
                        builder.Append(c);
                    }
                }
                else
                {
                    builder.Append(text[i]);
                }
            }

            builder.Append(numbers[numbers.Length - 1]);
            return builder.ToString();
        }

        static string Encrypt(string message, string cypher)
        {
            var output = new StringBuilder();
            if (message.Length > cypher.Length)
            {

                for (int i = 0; i <= message.Length - cypher.Length; i++)
                {

                    cypher += cypher[i];
                }

                for (int i = 0; i < message.Length; i++)
                {
                    int mess = CharToCode[message[i]];
                    int cyph = CharToCode[cypher[i]];

                    char symbol = (char)((mess ^ cyph) + 65);
                    output.Append(symbol);
                }

            }
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    int mess = CharToCode[message[i]];
                    int cyph = CharToCode[cypher[i]];

                    char symbol = (char)((mess ^ cyph) + 65);
                    output.Append(symbol);
                }

                int j = 0;
                for (int i = message.Length; i < cypher.Length; i++)
                {
                    int mess = CharToCode[output[j]];
                    int cyph = CharToCode[cypher[i]];

                    char symbol = (char)((mess ^ cyph) + 65);
                    output[j] = symbol;
                    j++;
                }
            }


            return output.ToString();
        }
        static string Decrypt(string encrypted, string cypher)
        {
            var output = new StringBuilder();

            if (encrypted.Length > cypher.Length)
            {
                var extendedCypher = new StringBuilder();
                int j = 0;
                for (int i = 0; i <= encrypted.Length - cypher.Length; i++)
                {

                    extendedCypher.Append(cypher[j]);
                    j++;
                    if (j >= cypher.Length)
                    {
                        j = 0;
                    }
                }

                cypher += extendedCypher.ToString();

                for (int i = 0; i < encrypted.Length; i++)
                {
                    int mess = encrypted[i] - 65;
                    int cyph = cypher[i] - 65;

                    char symbol = (char)((mess ^ cyph) + 65);
                    output.Append(symbol);
                }
            }
            else if (cypher.Length < encrypted.Length)
            {
                for (int i = 0; i < encrypted.Length; i++)
                {
                    int mess = CodeToChar[(char)(encrypted[i] - 65)];
                    int cyph = CodeToChar[(char)(cypher[i] - 65)];

                    char symbol = (char)((mess ^ cyph) + 65);
                    output.Append(symbol);
                }

                int j = 0;
                for (int i = encrypted.Length; i < cypher.Length; i++)
                {
                    int mess = CodeToChar[(char)(output[j] - 65)];
                    int cyph = CodeToChar[(char)(cypher[i] - 65)];

                    char symbol = (char)((mess ^ cyph) + 65);
                    output[j] = symbol;
                    j++;
                }
            }
            else
            {
                for (int i = 0; i < cypher.Length; i++)
                {
                    int mess = CharToCode[encrypted[i]];
                    int cyph = CharToCode[cypher[i]];

                    char symbol = (char)((mess ^ cyph) + 65);
                    output.Append(symbol);
                }
            }
            return output.ToString();
        }
    }
}
