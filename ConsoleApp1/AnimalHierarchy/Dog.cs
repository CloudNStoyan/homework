using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Dog : Animal , ISound
    {
        public DogBreed Breed { get; private set; }

        public Dog(string name, int age, Gender sex, DogBreed breed) : base(name, age, sex)
        {
            Breed = breed;
        }

        public void Sound()
        {
            Console.WriteLine("Bau Bau!!");
        }

        public enum DogBreed
        {
            GermanShepard,
            Rotvailer,
            Pitbul,
            Chihuahua
        }
    }
}
