using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetClassPropertiesAndPrintThem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < typeof(SomeClass).GetProperties().Length; i++)
            {
                Console.WriteLine(typeof(SomeClass).GetProperties()[i]);
            }
        }
    }

    class SomeClass
    {
        public string SomeProp1 { get; set; }
        public int SomeProp2 { get; set; }

        public SomeClass()
        {

        }
    }
}
