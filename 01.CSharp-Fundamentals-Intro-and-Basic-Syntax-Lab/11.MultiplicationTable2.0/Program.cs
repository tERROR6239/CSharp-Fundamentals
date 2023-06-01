using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());
            for (int i = startNumber; i <= 10; i++)
            {
                int multiply = number;
                multiply *= i;
                if (startNumber > 10)
                {
                    break;
                }
                Console.WriteLine($"{number} X {i} = {multiply}");
                
            }
            if (startNumber > 10)
            {
                Console.WriteLine($"{number} X {startNumber} = {number * startNumber}");
            }

        }
    }
}
