using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public class Event : EventArgs
    {
        public Event(string s)
        {
            message = s;
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
