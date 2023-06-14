using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            double result = Factorial(first) / Factorial(second);

            Console.WriteLine($"{result:F2}");
        }

        private static double Factorial(int factorial)
        {

            double result = factorial;
            for (int i = factorial - 1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
