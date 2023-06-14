using System;
 namespace _04.CSharp_Fundamentals_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(0, 10);
            PrintNumbers(11, 20);
            PrintNumbers(21, 30);
        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
            Console.WriteLine("The number is " + i);

            }
        }
    }
}
