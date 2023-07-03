using System;
using System.Drawing;

namespace _02.BitAtPosition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data = int.Parse(Console.ReadLine());
            int mask = int.Parse(Console.ReadLine());
            string binaryData = "";
            string binaryMask = "";
            string binaryResult = "";
            int result = data & mask;

            DecimalToBinary(ref data, ref binaryData);

            DecimalToBinary(ref mask, ref binaryMask);

            DecimalToBinary(ref result, ref binaryResult);

            Console.WriteLine($"Dec & Binary");
            Console.WriteLine($"{data:d2} --> {binaryData}");
            Console.WriteLine($"{mask:d2} --> {binaryMask}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"{result:d2} --> {binaryResult}");
        }

        private static void DecimalToBinary(ref int data, ref string binaryData)
        {
            int temp = data;
            while (temp > 0)
            {
                int remainder = temp % 2;
                temp /= 2;
                binaryData = remainder.ToString() + binaryData;
            }
        }

    }
}
