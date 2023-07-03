using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _04.SoftUniParking
{
    class User 
    {
        public User(string userName, string licenseOlateNumber)
        {
            UserName = userName;
            LicensePlateNumber = licenseOlateNumber;
        }

        public string UserName { get; set; }
        public string LicensePlateNumber { get; set; }

        public override string ToString()
        {
            return $"{UserName} => {LicensePlateNumber}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> database = new Dictionary<string, User>();

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string userName = arguments[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = arguments[2];
                        User newUser = new User(userName, licensePlateNumber);
                        if (!database.ContainsKey(newUser.UserName))
                        {
                            database.Add(newUser.UserName, newUser);
                            Console.WriteLine($"{newUser.UserName} registered {newUser.LicensePlateNumber} successfully");
                        }
                        else 
                        {
                            User foundUser = database[newUser.UserName];
                            Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlateNumber}");
                        }
                        break;

                    case "unregister":

                        if (database.ContainsKey(userName))
                        {
                            database.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        else 
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                }
            }

            foreach (User user in database.Values)
            {
                Console.WriteLine(user);
            }
        }
    }
}
