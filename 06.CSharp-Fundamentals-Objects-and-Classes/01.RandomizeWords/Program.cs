﻿ using System;
using System.Linq;

namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                string valueAtIndex = input[i];
                int randomIndex = random.Next(0, input.Length);
                string randomValueAtIndex = input[randomIndex];
                input[i] = randomValueAtIndex;
                input[randomIndex] = valueAtIndex;
            }

            foreach (string value in input)
            {
                Console.WriteLine(value);
            }
        }
    }
}
