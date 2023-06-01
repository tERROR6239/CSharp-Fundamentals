using System;
using System.Linq;

namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }

            //version 1
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[numbers.Length - 1 - i] + " ");
            }
            Console.WriteLine();

            //version 2
            Console.Write("Version 2 -> ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            //version 3
            numbers = numbers.Reverse().ToArray();
            Console.Write("Version 3 -> ");
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
