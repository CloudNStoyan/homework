using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariationsOfSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
            
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            string[] array = new string[n*n];
            int l = 0;
            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= n; j++)
                {
                    array[l] = "| " + i + ",";
                    for (int m = 0; m <= k-2; m++)
                    {
                        if (m == k - 2)
                        {
                            array[l] += (j + m);
                        }
                        else
                        {
                            array[l] += (j + m) + ",";
                        }
                        if (m + j > n)
                        {
                            array[l] = "| ";
                            array[l] += "=====";
                            break;
                        }
                    }
                    array[l] += " |";
                    l++;
                }
            }
            Console.Clear();
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
