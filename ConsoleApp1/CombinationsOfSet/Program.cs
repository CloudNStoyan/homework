using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationsOfSet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int k = 2;
            string[] array = new string[n*k];
            int l = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = i+k-1; j < n+k-1; j++)
                {
                    
                    array[l] = "| " + i.ToString();
                    for (int m = 0; m < k-1; m++)
                    {
                        if (j+m-1 > n)
                        {
                            array[l] += " |";
                            break;
                        }
                        array[l] += " , " + (j+m);
                        if (m == k-2)
                        {
                            array[l] += " |";
                        }
                    }
                    l++;
                }
            }
            foreach (string x in array)
            {
                Console.WriteLine(x);
            }
        }
    }
}
