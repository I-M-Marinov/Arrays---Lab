using System;

namespace P2.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int index = 0; index < n; index++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[index] = number;
            }
            for (int i = numbers.Length-1; i >=0 ; i--)
            {
                Console.Write(numbers[i] + " ");
            }
          
        }
    }
}
