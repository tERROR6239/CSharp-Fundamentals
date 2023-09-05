using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<firstWord>(?:@|#)[A-Za-z]{3,}(?:@|#))(?<secondWord>(?:@|#)[A-Za-z]{3,}(?:@|#))";

            List<string> mirrors = new List<string>();
            int pairCount = 0;

            foreach (Match match in Regex.Matches(input, pattern))
            {
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = match.Groups["secondWord"].Value;

                if (firstWord[0] == firstWord[firstWord.Length - 1] &&
                    firstWord[0] == secondWord[0] &&
                    firstWord[0] == secondWord[secondWord.Length - 1])
                {
                    pairCount++;

                    string mirrored = new string(secondWord.Reverse().ToArray());

                    if (firstWord == mirrored)                    
                    {
                        string cleanPattern = @"(?:@|#)";
                        string cleanFirstWord = Regex.Replace(firstWord, cleanPattern, "");
                        string cleanSecondWord = Regex.Replace(secondWord, cleanPattern, "");

                        mirrors.Add($"{cleanFirstWord} <=> {cleanSecondWord}");
                    }
                }
            }

            if (pairCount <= 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{pairCount} word pairs found!");
            }

            if (mirrors.Count > 0)
            {
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrors));
            }
            else 
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
