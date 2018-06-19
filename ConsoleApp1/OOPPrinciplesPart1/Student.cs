using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart1
{
    public class Student : Person
    {
        public int ClassNumber { get; private set; }

        public Student(string name,int age ,int classNumber) : base(name,age)
        {
            ClassNumber = classNumber;
        }

        public static Student Default()
        {
            return new Student("None",-1,-1);
        }
    }
}
