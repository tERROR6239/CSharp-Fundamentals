using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            var wordsCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string currentWordLowerCase = word.ToLower();
                if (!wordsCount.ContainsKey(currentWordLowerCase))
                {
                    wordsCount[currentWordLowerCase] = 0;
                }
                wordsCount[currentWordLowerCase]++;
            }

            foreach (var kvp in wordsCount)
            {
                if (kvp.Value % 2 == 0)
                {
                    continue;
                }
                Console.Write(kvp.Key + " ");
            }

        }
    }
}
