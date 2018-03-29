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
