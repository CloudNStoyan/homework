using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // compares two strings lexicographically, optionally ignoring the case

            var result = Compare("wow", "ad", false);
            Console.WriteLine(result[0] + " " + result[1]);
        }

        static string[] Compare(string left, string right, bool ignoreCase)
        {
            string[] result = new string[2];

            int length = Math.Min(left.Length, right.Length);

            for (int i = 0; i < length; i++)
            {
                if (ignoreCase)
                {
                    left = left.ToLower();
                    right = right.ToLower();
                }
                if (left[i] < right[i])
                {
                    result[0] = left;
                    result[1] = right;
                    return result;
                } else if (left[i] > right[i])
                {
                    result[0] = right;
                    result[1] = left;
                    return result;
                }
            }

            if (left.Length > right.Length)
            {
                result[0] = left;
                result[1] = right;
            }
            else
            {
                result[0] = right;
                result[1] = left;
            }
            return result;
        }
    }
}
