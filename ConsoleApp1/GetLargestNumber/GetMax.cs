using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class GetMax
    {
        public static int Number(int n1, int n2)
        {
            int result;
            if (n1 > n2)
            {
                result = n1;
            }
            else
            {
                result = n2;
            }
            return result;
        }
    }
}
