﻿using System;

namespace _01.IntegerOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            double result = ((firstNum + secondNum) / thirdNum) * fourthNum;

            Console.WriteLine(result);

        }
    }
}
