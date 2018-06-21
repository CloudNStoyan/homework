using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Animal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Sex { get; private set; }

        public Animal(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
    }
}
