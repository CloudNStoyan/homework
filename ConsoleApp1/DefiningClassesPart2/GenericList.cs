using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    /*
     * Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
       Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
       Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
       Check all input parameters to avoid accessing elements at invalid positions.
     */
    class GenericList<T>
    {
        private int InitialCapacity = 20;
        public int Count { get; private set; }
        private T[] elements;

        public GenericList(int capacity)
        {
            elements = new T[capacity > InitialCapacity ? capacity : InitialCapacity];
            Count = capacity;
        }

        public GenericList()
        {
            elements = new T[InitialCapacity];
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                T value;

                if (index <= Count)
                {
                   value = this.elements[index];
                }
                else
                {
                    value = default(T);
                }

                return value;
            }
            set
            {
                if (index <= Count)
                {
                    this.elements[index] = value;
                }
            }
        }
        
        public void Add(T item)
        {
            elements[Count++] = item;
            CheckCapacity();
        }

        public void RemoveAt(int index)
        {
            T[] tempArr = new T[InitialCapacity];
            int realArrayIndex = 0;
            for (int i = 0; i < Count; i++)
            {
                if (i != index)
                {
                    tempArr[realArrayIndex] = elements[i];
                    realArrayIndex++;
                }
            }

            elements = tempArr;
            Count--;
        }

        public T[] ToArray()
        {
            T[] tempArr = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                tempArr[i] = elements[i];
            }

            return tempArr;
        }

        public T Max()
        {
            return this.ToArray().Max();
        }

        public T Min()
        {
            return this.ToArray().Min();
        }

        private void CheckCapacity()
        {
            if (Count == elements.Length)
            {
                T[] tempArr = new T[Count * 2];
                for (int i = 0; i < elements.Length; i++)
                {
                    tempArr[i] = elements[i];
                }

                elements = tempArr;
            }
        }

        public void Clear()
        {
            elements = new T[InitialCapacity];
        }

        public int Find(T item)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(elements[i],item))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
