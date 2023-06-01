using System;

namespace _06.TriplesOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startChar = 97;

            for (int i = startChar; i < startChar + n; i++)
            {
                for (int j = startChar; j < startChar + n; j++)
                {
                    for (int k = startChar; k < startChar + n; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
