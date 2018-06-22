using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Startup
    {
        static void Main(string[] args)
        {
            var myJaba = new Frog("Jaba The Hut",3,Gender.Male,Frog.FrogBreed.Julta);
            var myKotka = new Cat("Ruski Bradar",4,Gender.Male,Cat.CatBreed.Egyptian);
            var myTomCat = new Tomcat("Ma Kotka",2,Cat.CatBreed.Persian);

            Animal[] myAnimals = new Animal[] {myTomCat, myJaba, myKotka};

            Console.WriteLine(myAnimals.AverageAge());
        }
    }
}
