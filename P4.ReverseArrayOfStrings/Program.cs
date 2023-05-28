using System;
using System.Linq;

namespace P4.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine().Split(" ").ToArray();

            for (int i = 0; i < text.Length/2; i++)

            {
                var firstElement = text[i];
                var lastElement = text[text.Length - i - 1];

                text[i] = lastElement; 
                text[text.Length - i - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", text));

        }
    }
}
