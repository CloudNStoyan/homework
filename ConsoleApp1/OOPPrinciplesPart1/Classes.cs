using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart1
{
    class Classes
    {
        public Teachers[] Teachers { get; private set; }

        public Student[] Students { get; private set; }

        public string Name { get; private set; }

        public Classes(string className,Teachers[] teachers,Student[] students)
        {
            Name = className;
            Teachers = teachers;
            Students = students;
        }
    }
}
