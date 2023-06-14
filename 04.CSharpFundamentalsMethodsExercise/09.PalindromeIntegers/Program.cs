using System;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numAsStr = "";
            while ((numAsStr = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrom(numAsStr));
            }
        } 

        private static bool IsPalindrom(string input)
        {
            //string first = input.Substring(0, input.Length / 2);
            char[] arr = input.ToCharArray();

            Array.Reverse(arr);

            string second = new string(arr);
           //string second = temp.Substring(0, temp.Length / 2);

            return input == second;
        }
    }
}
