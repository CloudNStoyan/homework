using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {7,1,5,3,9};
            
            int k = int.Parse(Console.ReadLine());
            Array.Sort(nums);
            int index = Array.BinarySearch(nums, k);
            if (index < 0)
            {
                Console.WriteLine("There is no {0} number in the array!", k);
            }
            else
            {
                Console.WriteLine("There is {0} number in the sorted array at position {1}.",k,index);
            }
        }
    }
}
