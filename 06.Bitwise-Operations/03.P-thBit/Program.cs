using System;

namespace _03.P_thBit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int result = number & mask;
            int lsb = result >> position;
            Console.WriteLine(lsb);
        }
    }
}
