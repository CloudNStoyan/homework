using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DancingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine() + "");
            int n = int.Parse(Console.ReadLine() + "");
            string bits = "";
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine() + "");
                bits += Convert.ToString(number, 2);
            }

            int allSequence = (k > 1) ? 0 : 1;
            int currSequence = 1;
            for (int i = 1; i < bits.Length; i++)
            {
                if (currSequence == k)
                {
                    if (i + 1 < bits.Length)
                    {
                        if (bits[i + 1] == bits[i])
                        {
                            currSequence = 1;
                        }
                        else
                        {
                            allSequence++;
                            currSequence = 1;
                        }
                    }
                    else
                    {
                        allSequence++;
                    }
                }
                if (bits[i - 1] == bits[i])
                {
                    currSequence++;
                }
            }

            Console.WriteLine(allSequence);
        }
    }
}
