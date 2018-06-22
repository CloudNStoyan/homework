using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
   public class Tomcat : Cat , ISound
   {
       public Tomcat(string name,int age,CatBreed breed) : base(name,age,Gender.Male,breed) { }

       public void Sound()
       {
           Console.WriteLine("TomCat Says MEEEOWW!!!");
       }
    }
}
