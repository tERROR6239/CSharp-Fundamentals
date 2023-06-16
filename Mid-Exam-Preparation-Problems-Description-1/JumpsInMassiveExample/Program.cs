using System;

namespace JumpsInMassiveExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            int initialIndex = 0;

            for (int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                initialIndex = (initialIndex + n) % numbers.Length;
                Console.WriteLine(initialIndex);
            }

        }
    }
}
