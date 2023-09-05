using System;
using System.Linq;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] usernames = input.Split(", ");

            foreach (var username in usernames)
            {
                if (username.Length < 3 || username.Length >16)
                {
                    continue;
                }
                bool isValidUsername = username.All(character => char.IsLetterOrDigit(character) || character == '-' || character == '_');
                if (isValidUsername) 
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
