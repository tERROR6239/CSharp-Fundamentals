using System;

namespace _01.SmallestОfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallestNumber = FindSmallestNumber();
            Console.WriteLine(smallestNumber);
        }

        static int FindSmallestNumber()
        {
            int smallestNumber = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }

            return smallestNumber;
        }
    }
}
