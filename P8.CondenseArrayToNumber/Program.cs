using System;
using System.Linq;

namespace P8.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length-1];

            if (numbers.Length <= 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {

                    for (int c = 0; c < condensed.Length - i; c++)
                    {
                        condensed[c] = numbers[c] + numbers[c + 1];
                    }
                    numbers = condensed;
                }
                Console.WriteLine(condensed[0]);
            }
        }
    }
}
