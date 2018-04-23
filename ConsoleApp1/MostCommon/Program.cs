using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() + "");
            var fName = new List<string>();
            var lName = new List<string>();
            var birthDay = new List<int>();
            var eyeColor = new List<string>();
            var hairColor = new List<string>();
            var height = new List<int>();

            var fNames = new Dictionary<string,int>();
            var lNames = new Dictionary<string,int>();
            var birthDays = new Dictionary<int,int>();
            var eyeColors = new Dictionary<string,int>();
            var hairColors = new Dictionary<string,int>();
            var heights = new Dictionary<int,int>();


            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] words = line.Split(',');
                fName.Add(words[0].Split(' ')[0]);
                lName.Add(words[0].Split(' ')[1]);
                birthDay.Add(int.Parse(words[1]));
                eyeColor.Add(words[2]);
                hairColor.Add(words[3]);
                height.Add(int.Parse(words[4]));
            }


            for (int i = 0; i < n; i++)
            {
                string firstName = fName[i];
                string lastName = lName[i];
                int birthYear = birthDay[i];
                string colorOfEye = eyeColor[i];
                string colorOfhair = hairColor[i];
                int heightOfCharacter = height[i];

                if (!fNames.ContainsKey(firstName))
                {
                    fNames.Add(firstName,1);
                }
                else
                {
                    fNames[firstName]++;
                }

                if (!lNames.ContainsKey(lastName))
                {
                    lNames.Add(lastName,1);
                }
                else
                {
                    lNames[lastName]++;
                }

                if (!birthDays.ContainsKey(birthYear))
                {
                    birthDays.Add(birthYear, 1);
                }
                else
                {
                    birthDays[birthYear]++;
                }

                if (!eyeColors.ContainsKey(colorOfEye))
                {
                    eyeColors.Add(colorOfEye,1);
                }
                else
                {
                    eyeColors[colorOfEye]++;
                }

                if (!hairColors.ContainsKey(colorOfhair))
                {
                    hairColors.Add(colorOfhair,1);
                }
                else
                {
                    hairColors[colorOfhair]++;
                }

                if (!heights.ContainsKey(heightOfCharacter))
                {
                    heights.Add(heightOfCharacter,1);
                }
                else
                {
                    heights[heightOfCharacter]++;
                }
            }

            PrintMostCommonFirstName(fNames);
            PrintMostCommonLastName(lNames);
            PrintMostCommonBirthDay(birthDays);
            PrintMostCommonColorEye(eyeColors);
            PrintMostCommonHairColor(hairColors);
            PrintMostCommonHeight(heights);
        }

        static void PrintMostCommonFirstName(Dictionary<string, int> fNameDictionary)
        {
            int mostUsed = 0;
            string outputMostUsedName = "";
            foreach (var i in fNameDictionary)
            {
                if (i.Value > mostUsed)
                {
                    mostUsed = i.Value;
                    outputMostUsedName = i.Key;
                }
            }
            Console.WriteLine(outputMostUsedName);
        }

        static void PrintMostCommonLastName(Dictionary<string, int> lNameDictionary)
        {
            int mostUsed = 0;
            string outputMostUsedName = "";
            foreach (var i in lNameDictionary)
            {
                if (i.Value > mostUsed)
                {
                    mostUsed = i.Value;
                    outputMostUsedName = i.Key;
                }
            }
            Console.WriteLine(outputMostUsedName);
        }

        static void PrintMostCommonBirthDay(Dictionary<int, int> birtDayDictionary)
        {
            int mostUsed = 0;
            int outputMostUsedBirthDay = 0;
            foreach (var i in birtDayDictionary)
            {
                if (i.Value > mostUsed)
                {
                    mostUsed = i.Value;
                    outputMostUsedBirthDay = i.Key;
                }
            }
            Console.WriteLine(outputMostUsedBirthDay);
        }

        static void PrintMostCommonColorEye(Dictionary<string, int> colorEyeDictionary)
        {
            int mostUsed = 0;
            string outputMostUsedEyeColor = "";
            foreach (var i in colorEyeDictionary)
            {
                if (i.Value > mostUsed)
                {
                    mostUsed = i.Value;
                    outputMostUsedEyeColor = i.Key;
                }
            }
            Console.WriteLine(outputMostUsedEyeColor);
        }

        static void PrintMostCommonHairColor(Dictionary<string, int> colorHairDictionary)
        {
            int mostUsed = 0;
            string outputMostUsedHairColor = "";
            foreach (var i in colorHairDictionary)
            {
                if (i.Value > mostUsed)
                {
                    mostUsed = i.Value;
                    outputMostUsedHairColor = i.Key;
                }
            }
            Console.WriteLine(outputMostUsedHairColor);
        }

        static void PrintMostCommonHeight(Dictionary<int, int> heightsDictionary)
        {
            int mostUsed = 0;
            int outputMostUsedHeight = 0;
            foreach (var i in heightsDictionary)
            {
                if (i.Value > mostUsed)
                {
                    mostUsed = i.Value;
                    outputMostUsedHeight = i.Key;
                }
            }
            Console.WriteLine(outputMostUsedHeight);
        }
    }
}
