using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DecodeAndDecrypt
{
    class Program
    {
       private static Dictionary<char,int> CharToCode = new Dictionary<char, int>
        {
            {'A' ,0},
            {'B' ,1},
            {'C' ,2},
            {'D' ,3},
            {'E' ,4},
            {'F' ,5},
            {'G' ,6},
            {'H' ,7},
            {'I' ,8},
            {'J' ,9},
            {'K' ,10},
            {'L' ,11},
            {'M' ,12},
            {'N' ,13},
            {'O' ,14},
            {'P' ,15},
            {'Q' ,16},
            {'R' ,17},
            {'S' ,18},
            {'T' ,19},
            {'U' ,20},
            {'V' ,21},
            {'W' ,22},
            {'X' ,23},
            {'Y' ,24},
            {'Z' ,25}
        };

        private static Dictionary<int,char> CodeToChar = new Dictionary<int, char>
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
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string decoded = Decoding(input);
           
           string cypher = GetCypher(decoded);
           string message = GetMessage(decoded, cypher.Length);

            Console.WriteLine(Decrypt(decoded,cypher));
            Console.WriteLine(cypher);
            Console.WriteLine(message);
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
                    Console.WriteLine($"| {mess} , {cyph} : {mess ^ cyph}|");

                    char symbol = (char) ((mess ^ cyph) + 65);
                    output.Append(symbol);
                }

                int j = 0;
                for (int i = message.Length; i < cypher.Length; i++)
                {
                    int mess = CharToCode[output[j]];
                    int cyph = CharToCode[cypher[i]];
                    Console.WriteLine($"| {mess} , {cyph} : {mess ^ cyph}|");

                    char symbol = (char) ((mess ^ cyph) + 65);
                    output[j] = symbol;
                    j++;
                }
            }


            return output.ToString();
        }

        static string Decrypt(string encrypted,string cypher)
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
            else
            {
                for (int i = 0; i < encrypted.Length; i++)
                {
                    int mess = CodeToChar[(char)(encrypted[i] - 65)];
                    int cyph = CodeToChar[(char)(cypher[i] - 65)];
                    Console.WriteLine($"| {mess} , {cyph} : {mess ^ cyph}|");

                    char symbol = (char)((mess ^ cyph) + 65);
                    output.Append(symbol);
                }

                int j = 0;
                for (int i = encrypted.Length; i < cypher.Length; i++)
                {
                    int mess = CodeToChar[(char)(output[j] - 65)];
                    int cyph = CodeToChar[(char)(cypher[i] - 65)];
                    Console.WriteLine($"| {mess} , {cyph} : {mess ^ cyph}|");

                    char symbol = (char)((mess ^ cyph) + 65);
                    output[j] = symbol;
                    j++;
                }
            }

            return output.ToString();
        }
        
        static string Encoding(string decrypted)
        {
            var encoded = new StringBuilder();
            int count = 1;
            for (int i = 1; i < decrypted.Length; i++)
            {
                if (i + 1 < decrypted.Length && decrypted[i] == decrypted[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        encoded.Append(decrypted[i] + "" + count);
                    }
                    else
                    {
                        encoded.Append(decrypted[i]);
                    }
                    count = 1;
                }
            }

            return encoded.ToString();
        }

        static string Decoding(string encoded)
        {
            var decoded = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
            {
                if (char.IsDigit(encoded[i]))
                {
                    int j = i;
                    string number = encoded[i].ToString();
                    while (char.IsDigit(encoded[j]))
                    {
                        if (!(j + 1 < encoded.Length))
                        {
                            break;
                        }
                        number += encoded[j];
                        j++;
                    }

                    int length = number != "" ? int.Parse(number) : 0;
                    for (int k = 0; k < length; k++)
                    {
                        number += encoded[i - 1];
                    }

                    decoded.Append(number);
                }
                else
                {
                    decoded.Append(encoded[i]);
                }
            }

            return decoded.ToString();
        }

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

        static string GetMessage(string encrypted, int cypherLength)
        {
            var output = new StringBuilder();
            int length = encrypted.Length - cypherLength - cypherLength.ToString().Length;
            string message = encrypted.Substring(0, length);
            output.Append(message);
            return output.ToString();
        }

    }
}
