using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static int[,] unSolvedSudoku = new int[9, 9];
        static int[,] solvedSudoku;
        static int[] currentPos = new []{0,0};

        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                lines.Add(Console.ReadLine());
            }

            // 0 = 1,0 2,0 3,0
            // 1 = 0,0 0,2 0,3

            for (int i = 0; i < unSolvedSudoku.GetLength(0); i++)
            {
                for (int j = 0; j < unSolvedSudoku.GetLength(1); j++)
                {
                    if (char.IsDigit(lines[i][j]))
                    {
                        unSolvedSudoku[i,j] = int.Parse(lines[i][j].ToString());
                    }
                    else
                    {
                        unSolvedSudoku[i, j] = 0;
                    }
                }
            }
            solvedSudoku = unSolvedSudoku;

            /*int[] result = new int[2];
            result[0] = 1;
            result[1] = 3;
            Console.WriteLine(isValid(1,result));*/
            while (isNotSolved())
            {

            }

            Print(unSolvedSudoku);
        }

        static void Print(int[,] sudoku)
        {
            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                for (int j = 0; j < sudoku.GetLength(1); j++)
                {
                    Console.Write("|" + sudoku[i,j]);
                }

                Console.WriteLine("|");
            }
        }

        static bool isNotSolved()
        {
            for (int i = 0; i < solvedSudoku.GetLength(0); i++)
            {
                for (int j = 0; j < solvedSudoku.GetLength(1); j++)
                {
                    if (solvedSudoku[i,j] == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static bool isValid(int number, int[] possition)
        {
            if (!Up(number, possition) || !Down(number, possition) || !Right(number, possition) || !Left(number, possition))
            {
                return false;
            }

            return true;
        }

        static bool Up(int number,int[] possition)
        {
            for (int i = possition[0] + 1; i < solvedSudoku.GetLength(0); i++)
            {
                if (solvedSudoku[i, possition[1]] == number)
                {
                    return false;
                }
            }
            return true;
        }

        static bool Down(int number, int[] possition)
        {
            for (int i = possition[0] - 1; i >= 0; i--)
            {
                if (solvedSudoku[i, possition[1]] == number)
                {
                    return false;
                }
            }
            return true;
        }

        static bool Right(int number, int[] possition)
        {
            for (int i = possition[1] + 1; i < solvedSudoku.GetLength(1); i++)
            {
                if (solvedSudoku[possition[0], i] == number)
                {
                    return false;
                }
            }
            return true;
        }

        static bool Left(int number, int[] possition)
        {
            for (int i = possition[1] - 1; i >= 0; i--)
            {
                if (solvedSudoku[possition[0], i] == number)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
