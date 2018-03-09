using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchInMatrix
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            int number = int.Parse(Console.ReadLine());
            int low = 0;
            int high = matrix.GetLength(0) * matrix.GetLength(1);
        }
    }
}
