using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart1
{
    class Teachers
    {
        public string[] Subjects { get; private set; }

        public Teachers(string[] subjects)
        {
            Subjects = subjects;
        }
    }
}
