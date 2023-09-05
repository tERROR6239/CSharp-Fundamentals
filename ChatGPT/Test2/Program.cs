using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        List<string> wordPairs = new List<string>();
        List<string> mirrorWords = new List<string>();

        string pattern = @"(@|#)[A-Za-z]{3,}\1\1[A-Za-z]{3,}\1";
        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            string wordPair = match.Value;
            wordPair = wordPair.Substring(1, wordPair.Length - 2); // Remove the surrounding "@" or "#"
            wordPairs.Add(wordPair);
        }

        foreach (string pair in wordPairs)
        {
            string[] words = pair.Split(new string[] { "##", "@@" }, StringSplitOptions.None);
            string wordOne = words[0];
            string wordTwo = words[1];
            string reversedWordOne = ReverseString(wordOne);

            if (reversedWordOne == wordTwo)
            {
                mirrorWords.Add($"{wordOne} <=> {wordTwo}");
            }
        }

        if (wordPairs.Count == 0)
        {
            Console.WriteLine("No word pairs found!");
        }
        else
        {
            Console.WriteLine($"{wordPairs.Count} word pairs found!");
        }

        if (mirrorWords.Count == 0)
        {
            Console.WriteLine("No mirror words!");
        }
        else
        {
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", mirrorWords));
        }
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
