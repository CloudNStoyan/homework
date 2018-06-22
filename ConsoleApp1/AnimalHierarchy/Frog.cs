using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Frog : Animal , ISound
    {
        public FrogBreed Breed { get; private set; }

        public Frog(string name, int age, Gender sex, FrogBreed breed) : base(name,age,sex)
        {
            Breed = breed;
        }

        public void Sound()
        {
            Console.WriteLine("Kvak!!");
        }

        public enum FrogBreed
        {
            Krasta,
            Julta,
            Kafqva

        }
    }
}
