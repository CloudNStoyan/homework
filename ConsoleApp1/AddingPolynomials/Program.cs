using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class Program
    {
        public static string polynomials(int[] arr1, int[] arr2)
        {
            string output = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                output += (arr1[i] + arr2[i]) + " ";
            }
            return output;
        }
        static void Main(string[] args)
        {
            //Write a method that adds two polynomials. Represent them as arrays of their coefficients. Write a program that reads two polynomials and prints their sum.
            int[] arr = {5, 0, 1};
            int[] arr2 = {7, 4, -3};
            Console.WriteLine(polynomials(arr,arr2));
        }
    }
}
