using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace _03.P_rates
{
    internal class Program
    {
        class Town 
        {
            public string Name { get; set; }
            public uint Population { get; set; }
            public uint Gold { get; set; }
        }

        static void Main(string[] args)
        {
            Dictionary<string, Town> townDict = new Dictionary<string, Town>();
            string input;
            while ((input = Console.ReadLine()) != "Sail") 
            {
                string[] townArguments = input.Split("||");

                string townName = townArguments[0];
                uint population = uint.Parse(townArguments[1]);
                uint gold = uint.Parse(townArguments[2]);

                if (!townDict.ContainsKey(townName))
                {
                    townDict.Add(townName, new Town());
                }

                townDict[townName].Name = townName;
                townDict[townName].Population += population;
                townDict[townName].Gold += gold;

                //Console.WriteLine($"{townDict[townName].Name} -> Population: {townDict[townName].Population} citizens, Gold: {townDict[townName].Gold} kg");
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split("=>");
                string townName = arguments[1]; 

                switch (arguments[0])
                {
                    case "Plunder":
                        uint killed = uint.Parse(arguments[2]);
                        uint gold = uint.Parse(arguments[3]);
                        Plunder(townDict, townName, killed, gold);
                        break;
                    case "Prosper":
                        int goldEarn = int.Parse(arguments[2]);
                        if (goldEarn < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else 
                        {
                            Prosper(townDict, townName, (uint)goldEarn);
                        }
                        break;
                }
            }

            if (townDict.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {townDict.Count} wealthy settlements to go to:");
                foreach (Town town in townDict.Values)
                {
                    Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }

        private static void Prosper(Dictionary<string, Town> towns, string townName, uint goldEarn)
        {
            if (towns.ContainsKey(townName))
            {
                towns[townName].Gold += goldEarn;
                Console.WriteLine($"{goldEarn} gold added to the city treasury. {townName} now has {towns[townName].Gold} gold.");
            }
        }

        private static void Plunder (Dictionary<string, Town> towns, string townName, uint killed, uint gold)
        {
            if (towns.ContainsKey(townName))
            {
                towns[townName].Population -= killed;
                towns[townName].Gold -= gold;
                Console.WriteLine($"{townName} plundered! {gold} gold stolen, {killed} citizens killed.");

                if (towns[townName].Population <= 0 || towns[townName].Gold <= 0)
                {
                    towns.Remove(townName);
                    Console.WriteLine($"{townName} has been wiped off the map!");
                }
            }
        }
    }
}
