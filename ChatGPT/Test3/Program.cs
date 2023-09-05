using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

        string input;
        while ((input = Console.ReadLine()) != "Sail")
        {
            string[] cityData = input.Split("||");
            string cityName = cityData[0];
            int population = int.Parse(cityData[1]);
            int gold = int.Parse(cityData[2]);

            if (!cities.ContainsKey(cityName))
            {
                cities.Add(cityName, new List<int>());
                cities[cityName].Add(population);
                cities[cityName].Add(gold);
            }
            else
            {
                cities[cityName][0] += population;
                cities[cityName][1] += gold;
            }
        }

        while ((input = Console.ReadLine()) != "End")
        {
            string[] eventDetails = input.Split("=>");
            string eventType = eventDetails[0];
            string cityName = eventDetails[1];

            if (eventType == "Plunder")
            {
                int peopleKilled = int.Parse(eventDetails[2]);
                int goldStolen = int.Parse(eventDetails[3]);

                cities[cityName][0] -= peopleKilled;
                cities[cityName][1] -= goldStolen;

                Console.WriteLine($"{cityName} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");

                if (cities[cityName][0] <= 0 || cities[cityName][1] <= 0)
                {
                    cities.Remove(cityName);
                    Console.WriteLine($"{cityName} has been wiped off the map!");
                }
            }
            else if (eventType == "Prosper")
            {
                int goldAdded = int.Parse(eventDetails[2]);

                if (goldAdded < 0)
                {
                    Console.WriteLine("Gold added cannot be a negative number!");
                }
                else
                {
                    cities[cityName][1] += goldAdded;
                    Console.WriteLine($"{goldAdded} gold added to the city treasury. {cityName} now has {cities[cityName][1]} gold.");
                }
            }
        }

        PrintResults(cities);
    }

    static void PrintResults(Dictionary<string, List<int>> cities)
    {
        if (cities.Count == 0)
        {
            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
        }
        else
        {
            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
            foreach (var city in cities)
            {
                string cityName = city.Key;
                int population = city.Value[0];
                int gold = city.Value[1];
                Console.WriteLine($"{cityName} -> Population: {population} citizens, Gold: {gold} kg");
            }
        }
    }
}
