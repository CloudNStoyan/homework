using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class GenericMatrix<T>
    {

        private T[,] elements;
        private int InitialCapacityRow = 20;
        private int InitialCapacityCol = 20;

        public int CurrentCapacityRow
        {
            get { return this.elements.GetLength(0); }
        }

        public int CurrentCapacityCol
        {
            get { return this.elements.GetLength(1); }
        }

        public GenericMatrix(int inputRow,int inputCol)
        {
            int row = inputRow > InitialCapacityRow ? inputRow : InitialCapacityRow;
            int col = inputCol > InitialCapacityCol ? inputCol : InitialCapacityCol;

            elements = new T[row,col];
        }

        public GenericMatrix(T[,] matrix)
        {
            elements = matrix;
        }

        public T[,] ToMatrix()
        {
            return elements;
        }

        public GenericMatrix()
        {
            elements = new T[InitialCapacityRow,InitialCapacityCol];
        }

        public T this[int row,int col]
        {
            get { return this.elements[row,col]; }
            set { this.elements[row,col] = value; }
        }

        public static GenericMatrix<T> operator +(GenericMatrix<T> firstGenericMatrix,GenericMatrix<T> secondGenericMatrix)
        {
            var firstMatrix = firstGenericMatrix.ToMatrix();
            var secondMatrix = secondGenericMatrix.ToMatrix();

            var resultMatrix = new T[firstMatrix.GetLength(0),firstMatrix.GetLength(1)];

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    //Some more work
                }
            }

            var resultGenericMatrix = new GenericMatrix<T>(resultMatrix);

            return resultGenericMatrix;
        }
    }
}
