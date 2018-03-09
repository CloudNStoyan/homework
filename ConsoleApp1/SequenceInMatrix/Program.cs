using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string matrixRange;
            int[,] matrix =
            {
                {4, 4, 4},
                {3, 3, 3},
                {3, 4, 4}
            };
            int[] sequence = new int[matrix.GetLength(0) * matrix.GetLength(1)];
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                sequence[i] = 1;
            }
            int count = 0;
            int temp = matrix[0,0];
            
            for (int coll = 0; coll < matrix.GetLength(0); coll++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    Console.WriteLine("| N: {0} | C: {1} | R: {2} | ", matrix[coll, row],coll,row);
                    if (temp == matrix[coll, row])
                    {
                        sequence[count]++;
                        temp = matrix[coll, row];
                    }
                    else
                    {
                        count++;
                        temp = matrix[coll, row];
                    }
                    
                }
            }
            Console.WriteLine("|=======L: {0} ========|",sequence.Length);
            if (sequence.Max() > sequence.Length)
            {
                Console.WriteLine("|=======M: {0} ========|", sequence.Max()-1);
            }
            else
            {
            Console.WriteLine("|=======M: {0} ========|",sequence.Max());
            }
        }
    }
}
