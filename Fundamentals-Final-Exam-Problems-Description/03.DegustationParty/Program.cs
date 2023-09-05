using System;
using System.Collections.Generic;

namespace _03.DegustationParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> meals = new Dictionary<string, List<string>>();
            List<string> unliked = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] arguments = command.Split("-");
                string guestName = arguments[1];
                string meal = arguments[2];

                switch (arguments[0])
                {
                    case "Like":
                        if (!meals.ContainsKey(guestName))
                        {
                            meals[guestName] = new List<string>();
                        }

                        if (!meals[guestName].Contains(meal))
                        {
                            meals[guestName].Add(meal);
                        }
                        break;

                    case "Dislike":
                        if (meals.ContainsKey(guestName))
                        {
                            if (meals[guestName].Contains(meal))
                            {
                                Console.WriteLine($"{guestName} doesn't like the {meal}.");
                                meals[guestName].Remove(meal);
                                unliked.Add(meal);
                            }
                            else
                            {
                                Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{guestName} is not at the party.");
                        }
                        break;
                }
            }

            foreach (var kvp in meals)
            {
                string guest = kvp.Key;
                List<string> liked = kvp.Value;
                Console.WriteLine($"{guest}: {string.Join(", ", liked)}");
            }            
            Console.WriteLine($"Unliked meals: {unliked.Count}");
        }    
    }
}
