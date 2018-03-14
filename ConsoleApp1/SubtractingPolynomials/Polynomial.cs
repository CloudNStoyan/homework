using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SubtractingPolynomials
{
    class Polynomial
    {
        public static string Add(int[] arr1, int[] arr2)
        {
            string output = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                output += (arr1[i] + arr2[i]) + " ";
            }
            return output;
        }
        public static string Multiply(int[] arr1, int[] arr2)
        {
            string output = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                output += (arr1[i] * arr2[i]) + " ";
            }
            return output;
        }
        public static string Subtract(int[] arr1, int[] arr2)
        {
            string output = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                output += (arr1[i] - arr2[i]) + " ";
            }
            return output;
        }
    }
}
