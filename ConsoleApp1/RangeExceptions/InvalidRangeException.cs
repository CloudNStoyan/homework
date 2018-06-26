using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class InvalidRangeException<T>
    {
        private string errorMessage;
        private string errorCondition;

        public InvalidRangeException(string message,string condition)
        {
            errorMessage = message;
            errorCondition = condition;
        }
    }
}
