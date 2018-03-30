using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task3HiddenMessage
{
    class Program
    {
        public static List<string> subitles = new List<string>();
        static void Main(string[] args)
        {
            //Tzacky has a great idea to hide messages in subtitles of movies. But his friend, just started to code and has difficulty 
            //decoding the messages. He knows that to do so, he needs to take the numbers that come before each subtitle and use 
            //them to decode the message. The first number I is the index of the symbol he should start decoding (starting from 0) 
            //and the second number S is the number of symbols he needs to skip to get every other symbol. If the starting index is 
            //larger than the length of the line, this means that the line should be skipped.
            //To make things easy, when the subtitles finish Tzacky always adds end instead of the starting index I (see sample tests).
            //Sometimes Tzacky wants to be extra sure his message will be hidden, so he decided to add additional complexity.
            //If S is negative your program should look for the next symbol to the left of the starting index (go backwards).
            //If I is negative your program should take the symbol counting from the end of the line as starting index
            string message = "";
            while (true)
            {
                string startingIndexHolder = Console.ReadLine() + "";
                if (startingIndexHolder == "end")
                {
                    break;
                }

                int startingIndex = int.Parse(startingIndexHolder);
                int numbersToSkip = int.Parse(Console.ReadLine() + "");
                string subtitle = Console.ReadLine() + "";

                if (startingIndex < 0)
                {
                    startingIndex += subtitle.Length;
                }

                message += AddToHidenMessage(startingIndex, numbersToSkip, subtitle);
            }
            Console.WriteLine(message);
        }

        public static string AddToHidenMessage(int startingIndex, int numbersToSkip, string subtitle)
        {
            string hiddenMessage = "";
            if (startingIndex > subtitle.Length - 1)
            {
                return "";
            }
            else
            {
                for (int i = startingIndex; i < subtitle.Length && i >= 0; i += numbersToSkip)
                {
                    hiddenMessage += subtitle[i];
                }

                return hiddenMessage;

            }
        }
    }
}
