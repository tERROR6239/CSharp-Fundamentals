using System;
using System.Data;
using System.Net.Security;
using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Encrypt(input));
        }

        private static string Encrypt(string input) 
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char originalChar = input[i];
                sb.Append((char)(originalChar + 3));
            }
            
            return sb.ToString();
        }
    }
}
