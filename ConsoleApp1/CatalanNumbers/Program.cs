using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //In combinatorics, the Catalan numbers are calculated by the following formula: 
            //catalan-formula
            //Write a program to calculate the Nth Catalan number by given N

            int n = int.Parse(Console.ReadLine());

            int Cn = (1 / (n + 1)) * ((n * n) / n);
            int k = 0;
            Console.WriteLine((n+k)*(n-k+1));
            Console.WriteLine("{0:F5}",Cn);
        }
    }
}
    