using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char downerChar = char.Parse(Console.ReadLine());
            char upperChar = char.Parse(Console.ReadLine());

            if ((int)downerChar < (int)upperChar)
            {
                AsciiToConsole(downerChar, upperChar);
            }
            else
            {
                AsciiToConsole(upperChar, downerChar);
            }

        }

        private static void AsciiToConsole(char downerChar, char upperChar)
        {
            for (int i = downerChar + 1; i < upperChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
