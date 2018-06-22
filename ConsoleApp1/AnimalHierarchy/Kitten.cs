using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Kitten : Cat , ISound
    {
        public Kitten(string name, int age, CatBreed breed) : base(name, age, Gender.Female, breed) { }

        public void Sound()
        {
            Console.WriteLine("meoww!!");
        }
    }
}
