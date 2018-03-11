using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            
            int crash = 0;
            

            int low = 0, height = matrix.Length;

            while (true)
            {
                int middle = low + ((height - low) / 2);
                string index = findIndex(middle);
                int coll = int.Parse(index[0].ToString()), row = int.Parse(index[2].ToString());

                int candidate = matrix[coll,row];

                if (candidate == number)
                {
                    Console.WriteLine(matrix[coll,row]);
                    break;
                }

                if (candidate > number)
                {
                    height = middle;
                }

                if (candidate < number)
                {
                    low = middle;
                }
            }
        }
        static string findIndex(int index)
        {
            string output = "";
            int coll = 0,row = 0;
            while (index >= 0)
            {
                if (index >= 3)
                {
                    coll++;
                    index -= 3;
                }
                else
                {
                    row = index;
                    if (row != 0)
                    {
                        row--;
                    }
                    if (coll != 0)
                    {
                        coll--;
                    }
                    output = coll + " " + row;
                    break;
                }
            }
            return output;
        }
    }
}
