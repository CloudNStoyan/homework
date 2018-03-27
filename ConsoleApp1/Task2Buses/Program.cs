using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Buses
{
    class Program
    {
        static void Main(string[] args)
        {
            //You know buses and their drivers - they all seem to have different opinion about the speed they move with. That leads to a lot 
            //of groups of buses that are grouped together. Since Stamat is a very smart and curious guy, he wants to be able to count the 
            //number of groups that are formed from a sequence of buses.

            //Given the sequence of the speeds of the buses, print on the console the number of groups that are formed.

            int groups = 0;
            int groupSpeed = 1501;
            int[] buses = (Console.ReadLine() + "").Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < buses.Length; i++)
            {
                int busSpeed = buses[i];

                if (busSpeed <= groupSpeed)
                {
                    groups++;
                    groupSpeed = busSpeed;
                }
            }

            Console.WriteLine(groups);
        }
    }
}
