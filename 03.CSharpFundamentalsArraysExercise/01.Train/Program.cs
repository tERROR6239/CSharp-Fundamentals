using System;
using System.Linq;


namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] wagons = new int[wagonsCount];

            for (int i = 0; i < wagonsCount; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                wagons[i] = passengers;
            }
            Console.WriteLine(string.Join(" ", wagons));
            // Console.WriteLine(wagons.Sum()); OR

            int total = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                total += wagons[i];
            }
            Console.WriteLine(total);
        }
    }
}
