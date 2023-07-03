using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int magicNumber = int.Parse(Console.ReadLine());           

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if ((array[i] + array[j]) == magicNumber && i != j) 
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                }
            }

        }
    }
}
