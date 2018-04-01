using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task5BobiAvokadoto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bobi Avokadoto loves to comb his hair(and to buy new combs). Bobi's head is represented by an integer N. All C combs that 
            //he can buy are also represented as integers. Bobi can use a comb only if his head and the comb don't have any overlapping 
            //set(1) bits(the 1s in N represent hairs and 0s represent bald spots and the 1s in a comb represent the comb's teeth). The best 
            //comb for Bobi is the comb with most teeth(bits set to 1) that he can use. Write a program that finds the best comb for Bobi by 
            //given N and combs, and prints it on the console.
            uint head = uint.Parse(Console.ReadLine() + "");
            int combCount = int.Parse(Console.ReadLine() + "");
            uint bestComb = 0;
            int bestCount = 0;

            for (int i = 0; i < combCount; i++)
            {
                uint comb = uint.Parse(Console.ReadLine() + "");

                if ((head & comb) == 0)
                {
                    int currentCount = 0;
                    for (int j = 0; j < 32 && (comb >> 1) > 0; j++)
                    {
                        currentCount += ((int)(comb >> j) & 1);
                    }

                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestComb = comb;
                    }
                }
            }

            Console.WriteLine(bestComb);
        }

        static string ToBinary(int n)
        {
            string holderOfBits = "";
            while (n > 0)
            {
                holderOfBits += n % 2;
                n /= 2;
            }

            string output = "";
            for (int i = holderOfBits.Length - 1; i >= 0; i--)
            {
                output += holderOfBits[i];
            }

            return output;
        }
    }
}
