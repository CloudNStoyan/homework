using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that sorts an array of integers using the Quick sort algorithm.

            string numbers = Console.ReadLine();
            var array = Array.ConvertAll(numbers.Split(' '), int.Parse);
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            list.Sort();
            bool isNotFinded = true;
            int crash = 0;
            int wall = 0, temp = 0, times = 0,index = array.Length - 1;
            int pivot = array[index];
            while (isNotFinded)
            {
                if (isNotFinded == false)
                {
                    break;
                }
                for (int i = wall; i < array.Length - 1; i++)
                {
                    if (array[i] < pivot)
                    {
                        temp = array[wall];
                        array[wall] = array[i];
                        array[i] = temp;
                        wall++;
                    } else if (array[i] > pivot)
                    {
                        times++;
                        if (times >= ((array.Length - 1) - wall))
                        {
                            temp = array[wall];
                            array[wall] = array[index];
                            array[index] = temp;
                            index--;
                            pivot = array[index];
                            wall++;
                        }
                    } else if (wall > (array.Length-1) || wall == (array.Length - 1)) //array.SequenceEqual(list)
                    {
                        
                        isNotFinded = false;
                        break;
                    }       
                }
                Console.WriteLine(array.Length - 1 + " A");
                Console.WriteLine(wall);
            }
            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
        }
    }
}
