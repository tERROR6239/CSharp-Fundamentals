using System;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string wordToRemove = Console.ReadLine();
           string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                int indexOfWord = text.IndexOf(wordToRemove);
                if (indexOfWord < 0)
                {
                    break;
                }
                text = text.Remove(indexOfWord, wordToRemove.Length);
            }
            Console.WriteLine(text);
        }
    }
}
