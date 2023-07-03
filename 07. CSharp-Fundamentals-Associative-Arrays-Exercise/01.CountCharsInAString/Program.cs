using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (character == ' ')
                {
                    continue;
                }

                if (!charOccurrences.ContainsKey(character))
                {
                    charOccurrences.Add(character, 0);
                }

                charOccurrences[character]++;
            }

            foreach (KeyValuePair<char, int> pair in charOccurrences)
            {
                char character = pair.Key;
                int occurrences = pair.Value;

                Console.WriteLine($"{character} -> {occurrences}");
            }
        }
    }
}
