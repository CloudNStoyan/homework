using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_class
{
    class Matrix
    {
        private int[,] matrix;
       
        public int Columns
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(1);
                
            }
        }
        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
        }

        public static Matrix Substract(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m1.Rows, m1.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }

        public static Matrix Add(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m1.Rows, m1.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }

        public static Matrix Multiply(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m1.Rows, m2.Columns);

            for (int row = 0; row < m1.Rows; row++)
            {
                for (int col = 0; col < m2.Columns; col++)
                {
                    int temp = 0;

                    for (int currentNumbers = 0; currentNumbers < m1.Columns; currentNumbers++)
                    {
                        temp += m1[row, currentNumbers] * m2[currentNumbers, col];
                    }

                    result[row, col] = temp;
                }
            }

            return result;
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            return Matrix.Add(m1, m2);
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            return Matrix.Substract(m1, m2);
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            return Matrix.Multiply(m1, m2);
        }
        public override string ToString()
        {
            string answer = null;

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    answer = answer + this.matrix[i, j] + " ";
                }

                answer = answer + "\n";
            }

            return answer;
        }
    }
}
