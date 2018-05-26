using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                numbers.Add(input != "0" ? int.Parse(input) : 1);
            }

            if (numbers.Count > 10)
            {
                List<int> firstTenSum = new List<int>();

                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        string number = numbers[i].ToString();

                        int sum = 1;
                        for (int j = 0; j < number.Length; j++)
                        {
                            sum *= number[j] != '0' ? int.Parse(number[j] + "") : 1;
                        }

                        firstTenSum.Add(sum);
                    }
                }


                long firstTenOutput = 1;

                for (int i = 0; i < firstTenSum.Count; i++)
                {
                    firstTenOutput *= firstTenSum[i];

                }

                List<int> secondSum = new List<int>();

                for (int i = 10; i < numbers.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        string number = numbers[i].ToString();

                        int sum = 1;
                        for (int j = 0; j < number.Length; j++)
                        {
                            sum *= number[j] != '0' ? int.Parse(number[j] + "") : 1;
                        }

                        secondSum.Add(sum);
                    }
                }

                long secondOutput = 1;

                for (int i = 0; i < secondSum.Count; i++)
                {
                    secondOutput *= secondSum[i];
                }

                Console.WriteLine(firstTenOutput);
                Console.WriteLine(secondOutput);

            }
            else
            {
                List<int> sums = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        string number = numbers[i].ToString();

                        int sum = 1;
                        for (int j = 0; j < number.Length; j++)
                        {
                            sum *= number[j] != '0' ? int.Parse(number[j] + "") : 1;
                        }

                        sums.Add(sum);
                    }
                }


                int output = 1;

                for (int i = 0; i < sums.Count; i++)
                {
                    output *= sums[i];
                }

                Console.WriteLine(output);
            }
        }
    }
}
