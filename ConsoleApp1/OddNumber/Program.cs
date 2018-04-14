using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() + "");
            long[] arr = new long[n];

            var dic = new Dictionary<long,int>();

            long oddOne = 0;

            for (long i = 0; i < n; i++)
            {
                arr[i] = long.Parse(Console.ReadLine() + "");
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                }
                else
                {
                    dic.Add(arr[i],1);
                }
            }

            foreach (var item in dic)
            {
                if (item.Value % 2 != 0)
                {
                    oddOne = item.Key;
                }
            }

            Console.WriteLine(oddOne);
        }
    }
}
