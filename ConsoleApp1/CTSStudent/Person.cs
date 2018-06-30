using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSStudent
{
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            if (this.age != null)
            {
                return $"{this.name}, {this.age}";
            }
            else
            {
                return $"{this.name}, Unspecified";
            }
        }
    }
}
