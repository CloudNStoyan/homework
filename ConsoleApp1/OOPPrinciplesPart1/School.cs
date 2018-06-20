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

        public List<string> SchoolComments { get; private set; }

        public School(string schoolName,string className,Teachers[] teachers,Student[] students) : base(className,teachers,students)
        {
            Name = schoolName;
        }

        public void Add(string comment)
        {
            SchoolComments.Add(comment);
        }
    }
}
