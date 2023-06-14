using System;

namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int targetCount = 0;
            double percent = n * 0.5d;

            while (n >= m) 
            {
                n -= m;
                targetCount++;

                if (percent == n && y != 0) 
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(targetCount);
        }
    }
}
