using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a sequence of positive integer values written into a string, separated by spaces. 
            //Write a function that reads these values from given string and calculates their sum. 
            //Write a program that reads a string of positive integers separated by spaces and prints their sum.
            string numbers = Console.ReadLine();
            var array = Array.ConvertAll(numbers.Split(' '), int.Parse);
            Console.WriteLine(array.Sum());
        }
    }
}
