using System;

namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int number = int.Parse(Console.ReadLine());

            string result = ReturnNxNMatrix(number);
            Console.WriteLine(result);
        }

        private static string ReturnNxNMatrix(int n) 
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result += $"{n} ";
                }

                result += "\n";
            }
            return result;
        }
    }
}
