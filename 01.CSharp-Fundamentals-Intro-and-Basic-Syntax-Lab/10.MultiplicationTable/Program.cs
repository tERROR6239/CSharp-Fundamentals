﻿using System;

namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());            
            for (int i = 1; i <= 10; i++)
            {
                int multiply = number;
                multiply *= i;
                Console.WriteLine($"{number} X {i} = {multiply}");
            }
            
        }
    }
}
