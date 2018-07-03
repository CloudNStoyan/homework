using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class InvalidRangeException<T>
    {
        private string message;
        private T start;
        private T end;

        public InvalidRangeException(string message,T start,T end)
        {
            this.message = message;
            this.start = start;
            this.end = end;
        }
    }
}
