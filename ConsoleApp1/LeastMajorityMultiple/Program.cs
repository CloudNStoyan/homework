using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastMajorityMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = int.Parse(Console.ReadLine() + "");
            arr[1] = int.Parse(Console.ReadLine() + "");
            arr[2] = int.Parse(Console.ReadLine() + "");
            arr[3] = int.Parse(Console.ReadLine() + "");
            arr[4] = int.Parse(Console.ReadLine() + "");

            List<int> lowests = new List<int>();

            int lowest = 1001;
            int majority = 0;
            int count = 0;
            bool stop = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j <= 1000; j++)
                {
                    if (stop)
                    {
                        break;
                    }
                    count = 0;
                    for (int k = arr.Length - 1; k >= 0; k--)
                    {
                        if (j % arr[k] == 0)
                        {
                            count++;
                            if (count > 2)
                            {
                                lowest = j;
                                stop = true;
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(lowest);
        }
    }
}
