using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        public int Grade { get; private set; }

        public Student(int grade, string fName, string lName) : base(fName, lName)
        {
            Grade = grade;
        }
    }
}
