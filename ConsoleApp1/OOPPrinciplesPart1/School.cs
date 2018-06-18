using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart1
{
    class School : Classes
    {
        public string Name { get; private set; }

        public School(string name)
        {
            Name = name;
        }


    }
}
