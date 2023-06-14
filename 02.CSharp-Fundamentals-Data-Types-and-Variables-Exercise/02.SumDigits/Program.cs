using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = number;
            int result = 0;

            while (number != 0)
            {
                digit = number % 10;
                result += digit;
                number /= 10;                
            }
            Console.WriteLine(Math.Abs(result));
        }
    }
}
