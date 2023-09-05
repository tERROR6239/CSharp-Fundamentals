using System;

namespace _04.BitDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int posotion = int.Parse(Console.ReadLine());
            int mask = ~(1 << posotion);
            int result = number & mask;
            Console.WriteLine(result);
        }
    }
}
