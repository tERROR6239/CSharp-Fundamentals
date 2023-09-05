using System;
using System.Collections.Generic;

namespace TEST3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> likedMeals = new Dictionary<string, List<string>>();
            List<string> unlikedMeals = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commandParts = input.Split('-');
                string action = commandParts[0];
                string guest = commandParts[1];
                string meal = commandParts[2];

                if (action == "Like")
                {
                    if (!likedMeals.ContainsKey(guest))
                    {
                        likedMeals[guest] = new List<string>();
                    }

                    if (!likedMeals[guest].Contains(meal))
                    {
                        likedMeals[guest].Add(meal);
                    }
                }
                else if (action == "Dislike")
                {
                    if (likedMeals.ContainsKey(guest))
                    {
                        if (likedMeals[guest].Contains(meal))
                        {
                            likedMeals[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            unlikedMeals.Add(meal);
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
            }

            // Print guests with their liked meals
            foreach (var kvp in likedMeals)
            {
                string guest = kvp.Key;
                List<string> meals = kvp.Value;
                Console.WriteLine($"{guest}: {string.Join(", ", meals)}");
            }

            // Print count of unliked meals
            Console.WriteLine($"Unliked meals: {unlikedMeals.Count}");
        }
    }
}
