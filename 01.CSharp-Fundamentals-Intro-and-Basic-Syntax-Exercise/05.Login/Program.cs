using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string reverseUser = "";
            int attempt = 0;
            bool blocked = false;

            for (int i = user.Length - 1; i >= 0; i--)
            {
                reverseUser += user[i];
            }

            string password = Console.ReadLine();

            while (reverseUser != password)
            {                
                attempt ++;
                if (attempt > 3) 
                {
                    blocked = true; 
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
            }

            if (blocked == true)
            {
                Console.WriteLine($"User {user} blocked!");
            }
            else 
            {
                Console.WriteLine($"User {user} logged in.");
            }              
        }
    }
}
