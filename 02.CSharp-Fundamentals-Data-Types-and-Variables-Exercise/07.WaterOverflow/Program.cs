using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int water = 0;
            for (int i = 0; i < number; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                water += liters;
                if (water > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    water -= liters; 
                }
            }                
                Console.WriteLine(water);            
        }
    }
}
