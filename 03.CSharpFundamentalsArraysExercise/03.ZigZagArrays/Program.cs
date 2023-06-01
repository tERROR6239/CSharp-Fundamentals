using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arrayFirst = new int[number];
            int[] arraySecond = new int[number];
            
            for (int i = 0; i < number; i++)
            {
                int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

                if (i % 2 != 0)
                {
                    arrayFirst[i] = array[1];
                    arraySecond[i] = array[0];
                }
                else 
                {
                    arraySecond[i] = array[1];
                    arrayFirst[i] = array[0];
                }               
            }
            Console.WriteLine(string.Join(" ", arrayFirst));
            Console.WriteLine(string.Join(" ", arraySecond));
        }
    }
}


