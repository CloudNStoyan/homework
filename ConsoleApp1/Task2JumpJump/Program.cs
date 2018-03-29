using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2JumpJump
{
    class Program
    {
        static void Main(string[] args)
        {
            //You're at a hiphop party in Schmedeswurtherwesterdeich in Germany, you're probably very drunk(hopefully you passed your C# 
            //Fundamentals exam at least) and DJ Tomekk is on the scene. Since DJ Tomekk is in the house, your task is to Jump, jump!. Unfortunately, 
            //since you've never been at a German hiphop party with DJ Tomekk in the town of Schmedeswurtherwesterdeich, you'll probably need to 
            //learn how to jump. Fortunately, you know a bit of programming, so you can follow the instructions from a single string value.

            //The instructions
            /*As mentioned above, the instructions are a single string. The instructions can contain digits(0-9) and the party symbol '^'.
             *You will start jumping from the first symbol of the instructions(at position 0).
             * If you jump on an even digit, do the following:
             * Take it's value P as a number('2' is 2, '4' is 4 and so on)
             * Jump P positions forward
             * If you jump on an odd digit
             * Take it's value P as a number('1' is 1, '3' is 3 and so on)
             * Jump P positions backwards
             * If you jump on a '0'(zero), you pass out because you've drank too much alchohol
             * Print Too drunk to go on after POSITION!, where POSITION is the index at which you jumped on the '0'
             * Stop jumping
             * If you jump on '^'(party symbol), you did some good jumping
             * Print Jump, Jump, DJ Tomekk kommt at POSITION!, where POSITION is the index at which you jumped on the party symbol '^'
             * Stop jumping
             * If you jump outside the boundaries of the instructions, you fall off the dancefloor
             * Print Fell off the dancefloor at POSITION!, where POSITION is the index at which you jumped you're out of the instructions
             * Stop jumping
             */

            string input = Console.ReadLine() + "";
            int i = 0;
            int p = 0;
            while (true)
            {
                if (i < 0 || i > input.Length)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", i);
                    break;
                } else if (input[i] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                    break;
                }
                else if (input[i] == '0')
                {
                    Console.WriteLine("Too drunk to go at {0}!", i);
                    break;
                }
                else if (input[i] % 2 == 0)
                {
                    p = int.Parse(input[i] + "");
                    i += p;
                }
                else if (input[i] % 2 > 0)
                {
                    p = int.Parse(input[i] + "");
                    i -= p;
                }
            }

            
        }
    }
}
