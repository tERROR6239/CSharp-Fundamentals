using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int result = 0;

            while (persons > 0)
            {
                persons -= capacity;
                result++;
            }
            Console.WriteLine(result);
        }
    }
}
