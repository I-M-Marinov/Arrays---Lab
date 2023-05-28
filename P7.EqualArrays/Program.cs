﻿using System;
using System.Linq;

namespace P7.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
                sum2 += array2[i];

                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else if (sum1 == sum2 && i == array1.Length - 1)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum1}");
                }
            }
           
        }
    }
}
