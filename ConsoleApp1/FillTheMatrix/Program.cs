using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3,3];
            int num = 1;
            for (int coll = 0; coll < matrix.GetLength(0); coll++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[coll, row] = num;
                    num++;
                }
            }
        }
    }
}
