using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            uint threshold = 1;
            int emojisCount = 0;
            List<string> CoolEmojis = new List<string>();

            string pattern = @"[0-9]";
            foreach (Match m in Regex.Matches(input, pattern))
            {
                threshold *= uint.Parse(m.Value);
            }

            string emojiPattern = @"(::|\*\*)(?<Emoji>[A-Z][a-z]{2,})\1";
            foreach (Match m in Regex.Matches(input, emojiPattern))
            {
                char[] EmojiCool = m.Value.ToCharArray();
                int coolness = 0;
                emojisCount ++;
                for (int i = 2; i < EmojiCool.Length - 2; i++)
                {
                    coolness += EmojiCool[i];
                }
                if (coolness > threshold) 
                {
                    CoolEmojis.Add(m.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojisCount} emojis found in the text. The cool ones are:");
            for (int i = 0; i < CoolEmojis.Count; i++)
            {
                Console.WriteLine(CoolEmojis[i]);
            }
        }
    }
}
