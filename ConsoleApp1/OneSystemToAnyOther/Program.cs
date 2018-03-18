using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSystemToAnyOther
{
    class Program
    {
        
        static void Convert(string n,int to, int from)
        {
            string input = n;
            int result = 0;
            int count = input.Length - 1;
            foreach (char c in input)
            {
                var map = new Dictionary<char, string>
                {
                    {'A', "10"},
                    {'B', "11"},
                    {'C', "12"},
                    {'D', "13"},
                    {'E', "14"},
                    {'F', "15"},
                };
                if (map.ContainsKey(c))
                {
                    result += int.Parse(map[c]) * int.Parse(Math.Pow(to, count).ToString());
                    count--;
                }
                else
                {
                    result += int.Parse(c.ToString()) * int.Parse(Math.Pow(to, count).ToString());
                    count--;
                }
            }

            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            //Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.
            string n = Console.ReadLine();
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            Convert(n,from,to);
        }
    }
}