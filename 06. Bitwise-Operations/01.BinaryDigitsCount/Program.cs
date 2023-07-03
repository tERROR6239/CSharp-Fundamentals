using System;

namespace _01.BinaryDigitsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());
            int count = 0;
            string result = "";

            while (number > 0) 
            {
                int remainder = number % 2;

                if (remainder == digit)
                {
                    count++;
                }
                number /= 2;
                result = remainder.ToString() + result;

            }
            Console.WriteLine(result);
            Console.WriteLine(count);
        }
    }
}
