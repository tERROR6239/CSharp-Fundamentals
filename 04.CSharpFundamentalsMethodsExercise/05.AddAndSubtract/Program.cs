using System;
using System.Diagnostics.CodeAnalysis;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int result = 0;

            result = SumNumbers(firstNum, secondNum);

            result = SubtractNumbers(third, result);

            Console.WriteLine(result);

        }
        private static int SumNumbers(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        private static int SubtractNumbers(int third, int result)
        {
            result -= third;
            return result;
        }

    }
}
