using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSystemToAnyOther
{
    class Program
    {
        static int toDecimal(string n , int baseId)
        {
            var hex = new Dictionary<char, int>
            {
                {'A', 10},
                {'B', 11},
                {'C', 12},
                {'D', 13},
                {'E', 14},
                {'F', 15}
            };
            double result = 0;
            int[] array = new int[n.Length];
            int count = 0;
            foreach (char c in n)
            {
                if (c >= '0' && c <= '9') 
                {
                    array[count] = int.Parse(c.ToString());
                }
                else
                {
                    array[count] = hex[c];
                }
                count++;
            }

            int pow = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] * Math.Pow(baseId, pow);
                pow--;
            }
            return int.Parse(result.ToString());
        }
        static void Convert(int n, int to)
        {
            var hex = new Dictionary<int, char>
            {
                {10, 'A'},
                {11, 'B'},
                {12, 'C'},
                {13, 'D'},
                {14, 'E'},
                {15, 'F'}
            };
            string result = "";
            int remainder = 0;
            int number = n;
            int temp = n;
            int times = 0;
            while (temp > 0)
            {
                times++;
                temp = temp / to;
            }
            string[] array = new string[times];
            
            int count = 0;
                
            if (to == 10)
            {
                Console.WriteLine(n);
            }
            else
            {
                while (number > 0)
                {
                    remainder = number % to;
                    number = number / to;
                    array[count] = remainder.ToString();
                    count++;
                }

                if (to == 16)
                {
                    for (int i = array.Length - 1; i > 0; i--)
                    {
                        if (int.Parse(array[i]) >= 10)
                        {
                            result += hex[int.Parse(array[i])];
                        }
                        else
                        {
                            result += int.Parse(array[i]);
                        }
                    }
                }
                else
                {
                    foreach (string s in array)
                    {
                        if (int.Parse(s) >= 10)
                        {
                            result += hex[int.Parse(s)];
                        }
                        else
                        {
                            result += int.Parse(s);
                        }
                    }
                }

                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {
            //Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.
            string n = Console.ReadLine();
            int baseId = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            if (baseId == 10)
            {
                Convert(int.Parse(n),to);
            }
            else
            {
                Convert(toDecimal(n, baseId), to);
            }
        }
    }
}