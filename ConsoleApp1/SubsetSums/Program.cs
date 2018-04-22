using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine() + "");
            int lines = int.Parse(Console.ReadLine() + "");
            int[] arr = new int[lines];
            for (int i = 0; i < lines; i++)
            {
                arr[i] = int.Parse(Console.ReadLine() + "");
            }

            int[,] matrix = new int[lines,sum + 1];

            for (int i = 0; i < sum + 1; i++)
            {
                Console.Write("| " + i +" |");
            }

            Console.WriteLine();
            Print(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0)
                    { 

                    }
                }
            }


        }

        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("| " + matrix[i,j] + " |");
                }

                Console.WriteLine();
            }
        }
    }
}
