using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
             * Input              |      Output
             * 1 3 2 2 2 4        |
             * 3 3 3 2 4 4        |       13
             * 4 3 1 2 3 3        |
             * 4 3 1 3 3 1        |
             * 4 3 3 3 1 1        |
             */

            int[,] matrix =
            {
                {1,3,2,2,2,4},
                {3,3,3,2,4,4},
                {4,3,1,2,3,3},
                {4,3,1,3,3,1},
                {4,3,3,3,1,1}
            };
            List<int> sequence = new List<int>();
            List<int> allPossibleInts = new List<int>();
            for (int Col = 0; Col < matrix.GetLength(0); Col++)
            {
                for (int Row = 0; Row < matrix.GetLength(1); Row++)
                {
                    bool contains = allPossibleInts.Contains(matrix[Col, Row]);
                    if (contains == false)
                    {
                        allPossibleInts.Add(matrix[Col, Row]);
                    }
                }
            }
            int count = 0;
            foreach (int i in allPossibleInts)
            {
                sequence.Add(count);
                for (int Col = 0; Col < matrix.GetLength(0); Col++)
                {
                    for (int Row = 0; Row < matrix.GetLength(1); Row++)
                    {
                        if (matrix[Col, Row] == i)
                        {
                            sequence[count]++;
                        }
                    }
                }
                count++;
            }
            Console.WriteLine(sequence.Max() - 1);
        }
    }
}
