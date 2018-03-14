using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtractingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extend the previous program to support also subtraction and multiplication of polynomials.
            int[] arr = { 5, 0, 1 };
            int[] arr2 = { 7, 4, -3 };

            Console.WriteLine(Polynomial.Add(arr,arr2));
            Console.WriteLine(Polynomial.Multiply(arr,arr2));
            Console.WriteLine(Polynomial.Subtract(arr, arr2));
        }
    }
}
