using System;
using System.Collections.Concurrent;
using System.Linq;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            bool flag = true;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumLeft += array[j];
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    sumRight += array[k]; 
                }
                if (sumLeft == sumRight)
                {
                    Console.Write(i + " ");
                    flag = false;
                }
               
                sumLeft = 0;
                sumRight = 0;
            }
            if (array.Length == 1 && flag == true)
            {
                Console.Write("0");
            }
            else if (flag == true)
            {
                Console.Write("no");                
            }
        }
    }
}
