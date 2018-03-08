using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSumOfMatrix
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
            int sum = 0;
            for (int coll = 0; coll < matrix.GetLength(0); coll++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    sum += matrix[coll,row];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
