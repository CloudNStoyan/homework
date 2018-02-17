using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given N integers (given in a single line, separated by a space).
            //Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            //Elements are counted from 1 to N, so the first element is odd, the second is even, etc.   

            string input = Console.ReadLine();
            string[] array = input.Split(new char[] {' '});

            int sumOdds = 1;
            int sumEvens = 1;
            for (int i = 0; i < array.Length;i+=2)
            {
                sumOdds *= int.Parse(array[i]);
            }
            for (int i = 1; i < array.Length; i+=2)
            {
                sumEvens *= int.Parse(array[i]);
            }
            if (sumOdds == sumEvens)
            {
                Console.WriteLine("yes {0}", sumOdds);
            }
            else
            {
                Console.WriteLine("no {0} {1}",sumOdds,sumEvens);
            }
        }
    }
}
    