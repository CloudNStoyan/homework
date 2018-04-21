using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAllLoveBits
{
    class Program
    {
        static void Main(string[] args)
        {
            // P = Number
            // P~ = Binary Representation of P with inverted bits all 0 are 1 and all 1 are 0
            // P: = Reversed right to left P~
            // Pnew = (P^P~) & P:
            int n = int.Parse(Console.ReadLine() + "");
            int[] outputs = new int[n];
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine() + "");
                outputs[i] = Calculate(p);
            }

            Print(outputs);
        }


        static int Calculate(int p)
        {
            string pStrWaveHolder = Convert.ToString(p, 2);
            var pStrWave = new StringBuilder();
            for (int i = 0; i < pStrWaveHolder.Length; i++)
            {
                if (pStrWaveHolder[i] == '0')
                {
                    pStrWave.Append('1');
                }
                else
                {
                    pStrWave.Append('0');
                }
            }
            var pStrTwoDots = new StringBuilder();
            for (int i = pStrWave.Length - 1; i >= 0; i--)
            {
                pStrTwoDots.Append(pStrWaveHolder[i]);
            }

            int pWave = Convert.ToInt32(pStrWave.ToString(), 2);
            int pTwoDots = Convert.ToInt32(pStrTwoDots.ToString(), 2);

            return (p ^ pWave) & pTwoDots;
        }

        static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
