using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            int rotation = int.Parse(Console.ReadLine());
            int firstElement = 0;

            for (int i = 0; i < rotation; i++)
            {
                firstElement = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {                                      
                    array[j] = array[j + 1];                   
                }
                array[^1] = firstElement; 
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
