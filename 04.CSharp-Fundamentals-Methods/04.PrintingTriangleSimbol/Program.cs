using System;

namespace _04.PrintingTriangleSimbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number, '*');
        }

        private static void PrintTriangle(int number, char symbolToPrint)
        {
            PrintTopTriangle(number, symbolToPrint);
            PrintBottomTriangle(number - 1, symbolToPrint);
        }

        private static void PrintTopTriangle(int n, char symbolToPrint)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintTriangleRow(row, symbolToPrint);
            }
        }

        private static void PrintBottomTriangle(int n, char symbolToPrint)
        {
            for (int row = n; row >= 1; row--)
            {
                PrintTriangleRow(row, symbolToPrint);
            }
        }

        private static void PrintTriangleRow(int row, char symbol)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }
}
