using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal , ISound
    {
        public CatBreed Breed { get; private set; }

        public Cat(string name, int age, Gender sex, CatBreed breed) : base(name,age,sex)
        {
            Breed = breed;
        }

        public enum CatBreed
        {
            Persian,
            Normal,
            Egyptian,
            Angorian
        }

        public void Sound()
        {
            Console.WriteLine("MEOWWW");
        }
    }
}
