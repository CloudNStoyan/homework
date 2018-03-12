using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(2, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;
            Matrix matrix2 = new Matrix(2, 2);
            matrix2[0, 0] = 1;
            matrix2[0, 1] = 2;
            matrix2[1, 0] = 3;
            matrix2[1, 1] = 4;

            Matrix resultOfAdd = Matrix.Add(matrix2,matrix1);
            Matrix add = matrix1 + matrix2;

            Console.WriteLine(add);
            Console.WriteLine(resultOfAdd);

            Matrix resultOfSubtract = Matrix.Substract(matrix1, matrix2);
            Matrix subtract = matrix1 - matrix2;

            Console.WriteLine(resultOfSubtract);
            Console.WriteLine(subtract);

            Matrix resultOfMultiply = Matrix.Multiply(matrix1, matrix2);
            Matrix multiply = matrix1 * matrix2;

            Console.WriteLine(resultOfMultiply);
            Console.WriteLine(multiply);
        }
    }
}
