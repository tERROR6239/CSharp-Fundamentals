using System;
using System.Drawing;

namespace _02.BitAtPosition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data = int.Parse(Console.ReadLine());
            int mask = 1 << 1;
            int bit = data & mask;
            int result = bit >> 1;
            Console.WriteLine(result);
        }
       
    }
}
