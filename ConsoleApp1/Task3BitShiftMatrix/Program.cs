using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task3BitShiftMatrix
{
    class Program
    {
        public static int[] currentPos = { 4, 0 };
        static void Main(string[] args)
        {
            /*You are given rectangular matrix. The matrix is filled with numbers that are power of 2, as follows:
             *The bottom left corner holds the value 1
             *The next cell above holds value of 2, the next cell above holds of 4, etc…
             *The second cell the bottom row holds a value of 2, the cell next to it holds a value of 4
             *You have a pawn on the field. The pawn can only move to the cells that directly above, below it or right/left of it. We have four directions UP, DOWN, LEFT, RIGHT.
             */

            int cols = int.Parse(Console.ReadLine() + "");
            int rows = int.Parse(Console.ReadLine() + "");
            int coef = (cols > rows) ? cols : rows;
            int[] moves = (Console.ReadLine() + "").Split(' ').Select(int.Parse).ToArray();
            
            int[,] matrix = new int[rows, cols];
            FillMatrix(matrix);
            foreach (int move in moves)
            {
                int[] endPos = Coordinates(move, coef);
                if (endPos[1] > currentPos[1])
                {

                }

            }
            PrintMatrix(matrix);
        }
        static int[] Coordinates(int move, int coef)
        {
            int row = move % coef;
            int col = move / coef;      
            int[] result = new int[2];
            result[0] = col;
            result[1] = row;
            return result;
        }

        static void FillMatrix(int[,] matrix)
        {
            int pow = Convert.ToInt32(1 * Math.Pow(2, matrix.GetLength(0) - 1));
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[0, i] = pow;
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    matrix[j, i] = matrix[j > 0 ? j - 1 : j, i] / 2;
                }
                pow *= 2;
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0,4}",matrix[r,c] + " ");
                }
                Console.WriteLine();
            }
        }

        static int NextPosition(int[] whereTo, int[,] matrix)
        {
            int result = 0;
            //while (currentPos[0] != whereTo[0] && currentPos[1] != whereTo[1])

            if (currentPos[1] > whereTo[1])
            {
                if (hasPassed())
                {
                    result += Right(matrix);
                }
                else
                {
                    currentPos[1]++;
                }
            }
            else
            {
                if (hasPassed())
                {
                    result += Left(matrix);
                }
                else
                {
                    currentPos[1]--;
                }
            }

            return result;

        }

        static int Left(int[,] matrix)
        {
            return 0;
        }

        static int Right(int[,] matrix)
        {
            
            return matrix[currentPos[0], currentPos[1]+1];
            currentPos[1]++;
        }

        static bool hasPassed()
        {
            var passed = new Dictionary<string,int>
            {

            };
            string holderForPosition = currentPos[0] + " , " + currentPos[1];
            if (passed.ContainsKey(holderForPosition))
            {
                return false;
            }
            else
            {
                passed.Add(holderForPosition,0);
                return true;
            }
        }
    }
}
