using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cards = new Dictionary<string, int>()
            {
                {"2" ,10},
                {"3" ,9},
                {"4" ,8},
                {"5" ,7},
                {"6" ,6},
                {"7" ,5},
                {"8" ,4},
                {"9" ,3},
                {"10" ,2},
                {"A" ,1},
                {"J" ,11},
                {"Q" ,12},
                {"K" ,13}
            };

            int fPlayerScore = 0;
            int sPlayerScore = 0;

            int fPlayerGamesWon = 0;
            int sPlayerGamesWon = 0;

            int games = int.Parse(Console.ReadLine() + "");
            for (int i = 0; i < games; i++)
            {
                bool fWins = false;
                bool noBothX = true;

                string[] fPlayerHand = new string[3];
                fPlayerHand[0] = Console.ReadLine();
                fPlayerHand[1] = Console.ReadLine();
                fPlayerHand[2] = Console.ReadLine();

                int fPlayerMultiply = 0;
                int fPlayerSubstract = 0;
                bool fPlayerHasX = false;

                int fPlayerStrength = 0;

                foreach (var card in fPlayerHand)
                {
                    switch (card)
                    {
                        case "Z":
                            fPlayerMultiply = fPlayerMultiply == 0 ? 2 : fPlayerMultiply * 2;
                            break;
                        case "Y":
                            fPlayerSubstract += 200;
                            break;
                        case "X":
                            fPlayerHasX = true;
                            break;
                        default:
                            fPlayerStrength += cards[card];
                            break;
                    }
                }

                fPlayerScore *= fPlayerMultiply;
                fPlayerScore -= fPlayerSubstract;

                string[] sPlayerHand = new string[3];
                sPlayerHand[0] = Console.ReadLine();
                sPlayerHand[1] = Console.ReadLine();
                sPlayerHand[2] = Console.ReadLine();

                int sPlayerMultiply = 0;
                int sPlayerSubstract = 0;
                bool sPlayerHasX = false;

                int sPlayerStrength = 0;

                foreach (var card in sPlayerHand)
                {
                    switch (card)
                    {
                        case "Z":
                            sPlayerMultiply = sPlayerMultiply == 0 ? 2 : sPlayerMultiply * 2;
                            break;
                        case "Y":
                            sPlayerSubstract += 200;
                            break;
                        case "X":
                            sPlayerHasX = true;
                            break;
                        default:
                            sPlayerStrength += cards[card];
                            break;
                    }
                }

                sPlayerScore *= sPlayerMultiply;
                sPlayerScore -= sPlayerSubstract;



                if (fPlayerHasX && sPlayerHasX)
                {
                    sPlayerScore += 50;
                    fPlayerScore += 50;
                    noBothX = false;
                }
                else if (fPlayerHasX)
                {
                    fWins = true;
                    Console.WriteLine("X card drawn! Player one wins the match!");
                }
                else if (sPlayerHasX)
                {
                    fWins = false;
                    Console.WriteLine("X card drawn! Player two wins the match!");
                }
                else if (fPlayerStrength > sPlayerStrength)
                {
                    Console.WriteLine(
                        $"First player wins!\nScore: {fPlayerStrength + fPlayerScore}\nGames won: {fPlayerGamesWon + 1}");
                    fWins = true;
                }
                else if (sPlayerStrength > fPlayerStrength)
                {
                    Console.WriteLine(
                        $"Second player wins!\nScore: {sPlayerStrength + sPlayerScore}\nGames won: {sPlayerGamesWon + 1}");
                    fWins = false;
                }
                else if (sPlayerStrength == fPlayerStrength)
                {
                    Console.WriteLine($"It's a tie!\nScore: {fPlayerStrength}");
                    noBothX = false;
                }

                if (fWins && noBothX)
                {
                    fPlayerScore += fPlayerStrength;
                    fPlayerGamesWon++;
                }
                else if (!fWins && noBothX)
                {
                    sPlayerScore += sPlayerStrength;
                    sPlayerGamesWon++;
                }
            }
        }
    }
}
