using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetWithSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S.
            Console.Write("S: ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            bool isFinded = false;
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            while (j < array.Length)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    //if (array[j] + array[i] == s && array[j] != array[i])
                    //{
                    //    isFinded = true;
                    //}
                    if (array[i] != array[j])
                    {
                        result += array[i] + array[j];
                    }
                    if (result > s)
                    {
                        result = 0;
                    } else if (result == s)
                    {   
                        isFinded = true;
                        break;
                    }
                    
                }
                if (isFinded == true)
                {
                    Console.WriteLine("Yes");
                    break;
                }
                j++;
            }
            if (isFinded == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
