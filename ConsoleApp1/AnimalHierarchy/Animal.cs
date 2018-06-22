using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
   public class Animal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Gender Sex { get; private set; }

        public Animal(string name, int age, Gender sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
    }
}
