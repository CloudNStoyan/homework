using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class Program
    {
        public static int reverse(int number)
        {
            string strNumber = number.ToString();
            string temp = "";

            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                temp += strNumber[i];
            }
            int output = int.Parse(temp);
            return output;
        }
        public static int add(int[] arr1, int[] arr2)
        {
            int result = 0;
            string temp = "";
            int temp1 = 0, temp2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                temp += arr1[i];
            }
            temp1 = reverse(int.Parse(temp));
            temp = "";
            for (int i = 0; i < arr2.Length; i++)
            {
                temp += arr2[i];
            }
            temp2 = reverse(int.Parse(temp));
            result = reverse((temp1 + temp2));
            return result;
        }
        static void Main(string[] args)
        {
            int[] arr = {8, 3, 3};
            int[] arr2 = {6, 2, 4, 2};
            Console.WriteLine(add(arr,arr2));
        }
    }
}
