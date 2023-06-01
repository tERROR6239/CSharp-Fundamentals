using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            int topInt = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        topInt++;
                    }                    
                }
                if (topInt == array.Length - i - 1) 
                {
                    Console.Write(array[i] + " ");                    
                }
                topInt = 0;
            }
           
        }
    }
}
