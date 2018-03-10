using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace sortByStringLength
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[,] matrix =
            {
                {"Lorem ipsum dolor sit amet", "consectetur adipiscing elit", "Sed condimentum nisl non viverra auctor"}, // 0 Col
                {"Fusce non ex sit amet nunc venenatis interdum", "Maecenas tristique elementum lectus", "vitae laoreet massa iaculis tincidunt"}, // 1 Col
                {"Nulla eu felis facilisis", "fringilla augue at", "dignissim magna"}  // 2 Col
            };
            string temp;
            int check = 0;
            while (true)
            {
                if (check > matrix.Length-4)
                {
                    break;
                }
                check = 0;
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    for (int row = 1; row < matrix.GetLength(1); row++)
                    {
                        if (matrix[col, row].Length > matrix[col, row - 1].Length)
                        {
                            check++;
                        }
                    }
                }

                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        if (row + 1 > matrix.GetLength(1) - 1)
                        {
                            if (col + 1 > matrix.GetLength(0) - 1)
                            {
                                break;
                            }
                            if (matrix[col, row].Length > matrix[col + 1, 0].Length)
                            {
                                temp = matrix[col, row];
                                matrix[col, row] = matrix[col + 1, 0];
                                matrix[col + 1, 0] = temp;
                            }
                        }
                        else
                        {
                            if (matrix[col, row].Length > matrix[col, row + 1].Length)
                            {
                                temp = matrix[col, row];
                                matrix[col, row] = matrix[col, row + 1];
                                matrix[col, row + 1] = temp;
                            }
                        }
                    }
                }
            }
            foreach (string s in matrix)
            {
                Console.Write(s.Length + " ");
            }
            Console.WriteLine();
        }
    }
}
