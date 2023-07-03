using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToCharArray();
            MiddleChars(array);
        }

        private static void MiddleChars(char[] array)
        {
            if (array.Length % 2 != 0)
            {
                Console.WriteLine(array[array.Length / 2]);
            }
            else
            {
                Console.WriteLine($"{array[(array.Length / 2) - 1]}{array[(array.Length / 2)]}");
            }
        }
    }
}
