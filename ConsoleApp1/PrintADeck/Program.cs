using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a card sign(as a string) from the console and generates and prints all possible cards from a
            //standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the   
            //classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
            string[] arr = new string[4];

            arr[0] = "Clubs";
            arr[1] = "Diamonds";
            arr[2] = "Hearts";
            arr[3] = "Spades";

            string a = "";
            string two = "";
            string three = "";
            string four = "";
            string five = "";
            string six = "";
            string seven = "";
            string eight = "";
            string nine = "";
            string ten = "";
            string joker = "";
            string queen = "";
            string king = "";


            string input = Console.ReadLine();

            switch (input)
            {
                case "A":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    break;
                case "2":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " +arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    break;
                case "3":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    break;
                case "4":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    break;
                case "5":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                        five += "5" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    break;
                case "6":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                        five += "5" + " " + arr[i] + " ";
                        six += "6" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    Console.WriteLine(six);
                    break;
                case "7":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                        five += "5" + " " + arr[i] + " ";
                        six += "6" + " " + arr[i] + " ";
                        seven += "7" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    Console.WriteLine(six);
                    Console.WriteLine(seven);
                    break;
                case "8":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                        five += "5" + " " + arr[i] + " ";
                        six += "6" + " " + arr[i] + " ";
                        seven += "7" + " " + arr[i] + " ";
                        eight += "8" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    Console.WriteLine(six);
                    Console.WriteLine(seven);
                    Console.WriteLine(eight);
                    break;
                case "9":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                        five += "5" + " " + arr[i] + " ";
                        six += "6" + " " + arr[i] + " ";
                        seven += "7" + " " + arr[i] + " ";
                        eight += "8" + " " + arr[i] + " ";
                        nine += "9" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    Console.WriteLine(six);
                    Console.WriteLine(seven);
                    Console.WriteLine(eight);
                    Console.WriteLine(nine);
                    break;
                case "10":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                        five += "5" + " " + arr[i] + " ";
                        six += "6" + " " + arr[i] + " ";
                        seven += "7" + " " + arr[i] + " ";
                        eight += "8" + " " + arr[i] + " ";
                        nine += "9" + " " + arr[i] + " ";
                        ten += "10" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    Console.WriteLine(six);
                    Console.WriteLine(seven);
                    Console.WriteLine(eight);
                    Console.WriteLine(nine);
                    Console.WriteLine(ten);
                    break;
                case "J":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                        five += "5" + " " + arr[i] + " ";
                        six += "6" + " " + arr[i] + " ";
                        seven += "7" + " " + arr[i] + " ";
                        eight += "8" + " " + arr[i] + " ";
                        nine += "9" + " " + arr[i] + " ";
                        ten += "10" + " " + arr[i] + " ";
                        joker += "J" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    Console.WriteLine(six);
                    Console.WriteLine(seven);
                    Console.WriteLine(eight);
                    Console.WriteLine(nine);
                    Console.WriteLine(ten);
                    Console.WriteLine(joker);
                    break;
                case "Q":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                        five += "5" + " " + arr[i] + " ";
                        six += "6" + " " + arr[i] + " ";
                        seven += "7" + " " + arr[i] + " ";
                        eight += "8" + " " + arr[i] + " ";
                        nine += "9" + " " + arr[i] + " ";
                        ten += "10" + " " + arr[i] + " ";
                        joker += "J" + " " + arr[i] + " ";
                        queen += "Q" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    Console.WriteLine(six);
                    Console.WriteLine(seven);
                    Console.WriteLine(eight);
                    Console.WriteLine(nine);
                    Console.WriteLine(ten);
                    Console.WriteLine(joker);
                    Console.WriteLine(queen);
                    break;
                case "K":
                    for (int i = 0; i < arr.Length; i++)
                    {
                        a += "A" + " " + arr[i] + " ";
                        two += "2" + " " + arr[i] + " ";
                        three += "3" + " " + arr[i] + " ";
                        four += "4" + " " + arr[i] + " ";
                        five += "5" + " " + arr[i] + " ";
                        six += "6" + " " + arr[i] + " ";
                        seven += "7" + " " + arr[i] + " ";
                        eight += "8" + " " + arr[i] + " ";
                        nine += "9" + " " + arr[i] + " ";
                        ten += "10" + " " + arr[i] + " ";
                        joker += "J" + " " + arr[i] + " ";
                        queen += "Q" + " " + arr[i] + " ";
                        king += "K" + " " + arr[i] + " ";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    Console.WriteLine(six);
                    Console.WriteLine(seven);
                    Console.WriteLine(eight);
                    Console.WriteLine(nine);
                    Console.WriteLine(ten);
                    Console.WriteLine(joker);
                    Console.WriteLine(queen);
                    Console.WriteLine(king);
                    break;
                default:
                    break;
             
            }
        }
    }
}
