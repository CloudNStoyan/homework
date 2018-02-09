using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression to check if
            //given N is prime (i.e. it is divisible without remainder only to itself and 1).
            //Note: You should check if the number is positive
            //Input
            //On the only input line you will receive the number N.
            //Output
            //Output true if the number is prime and false otherwise.



            int input = int.Parse(Console.ReadLine());

            if (input != 1 && input > 0)
            {
                for (int i = 1; i < input; i++)
                {
                    if (input % i == 0)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        if (i == input)
                        {
                            Console.WriteLine(false);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine(false);
            }

            


        }
    }
}
