using System;
using System.Linq;

namespace P6._EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOfEven = 0;
            int sumOfOdd = 0;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int currentNumber = inputNumbers[i];

                if (currentNumber % 2 == 0)
                {
                    sumOfEven += currentNumber;
                }
                else if (currentNumber % 2 != 0)
                {
                    sumOfOdd += currentNumber;
                }
            }
            Console.WriteLine(sumOfEven - sumOfOdd);
        }
    }
}
