using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int, string>()
            {
                {3, "Fizz"},
                {5, "Buzz"}
            };


            for (int i = 1; i <= 100; i++)
            {
                var keys = dictionary.Keys;
                string text = "";

                foreach (int key in keys)
                {
                    if (i % key == 0)
                    {
                        text += dictionary[key];
                    }
                }

                if (string.IsNullOrEmpty(text))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(text);
                }
            }
        }
    }
}
