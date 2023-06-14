using System;

namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        private static void PrintTriangle(int number)
        {
            PrintTopTriangle(number);
            PrintBottomTriangle(number - 1);
        }

        private static void PrintBottomTriangle(int n)
        {
            for (int row = n; row >= 1; row--)
            {
                PrintTriangleRow(row);
            }
        }

        private static void PrintTopTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintTriangleRow(row);
            }
        }

        private static void PrintTriangleRow(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}
