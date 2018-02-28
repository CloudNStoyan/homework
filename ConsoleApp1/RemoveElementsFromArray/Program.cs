using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
            //Print the minimal number of elements that need to be removed in order for the array to become sorted.
            int n = int.Parse(Console.ReadLine());
            int howMany = 0;

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            list.Sort();
            for (int j = 0; j < list.Count; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (j != i && list[j] == list[i])
                    {
                        howMany++;
                        list.RemoveAt(i);
                        
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i + 1] != (list[i] + 1))
                {
                    howMany++;
                    list.RemoveAt(i+1);
                } else if (list[i - 1] != (list[i] - 1))
                {
                    howMany++;
                    list.RemoveAt(i-1);
                }
            }
            // this dosnt work i dunno know the logic search in google later
        }
    }
}
