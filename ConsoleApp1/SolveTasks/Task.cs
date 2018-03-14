using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTasks
{
    class Task
    {
        public static int Reverse(uint number)
        {
            int result = 0;
            string strNumber = number.ToString();
            string temp = "";

            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                temp += strNumber[i];
            }
            int output = int.Parse(temp);
            return output;
        }

        public static int AverageSequence(int[] arr)
        {
            List<int> sequences = new List<int>();
            int count = 0;
            sequences.Add(0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 <= arr.Length - 1)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        sequences[count] += 1;
                    }
                    else
                    {
                        sequences.Add(0);
                        count++;
                    }
                }
            }
            int result = 0;
            foreach (int i in sequences)
            {
                result += i;
            }
            return result / sequences.Count;
        }

        public static string LinearEquation(int x, int free)
        {
            if (x == 0)
            {
                return "X needs to be > 0";
            }
            else
            {
                string result = ((free * (-1)) / 2).ToString();
                return result;
            }
        }
    }
}
