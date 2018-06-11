using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class GenericMatrix<T>
    {

        private T[,] elements;
        private int InitialCapacityRow = 20;
        private int InitialCapacityCol = 20;
        public GenericMatrix(int inputRow,int inputCol)
        {
            int row = inputRow > InitialCapacityRow ? inputRow : InitialCapacityRow;
            int col = inputCol > InitialCapacityCol ? inputCol : InitialCapacityCol;

            elements = new T[row,col];
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
    }
}
