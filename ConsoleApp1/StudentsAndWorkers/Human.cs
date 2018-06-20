using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Human(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
    }
}
