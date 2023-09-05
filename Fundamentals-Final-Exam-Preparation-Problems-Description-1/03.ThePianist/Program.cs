using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < n; i++)
            {
                string[] lineTokens = Console.ReadLine().Split("<->");
                string name = lineTokens[0];
                int rarity = int.Parse(lineTokens[1]);

                if (plants.Any(x => x.Name == name))
                {
                    plants.FirstOrDefault(x => x.Name == name).Rarity = rarity;
                }
                else 
                {
                    plants.Add(new Plant(name, rarity));
                }
            }
                
            string line = string.Empty;            
            while ((line = Console.ReadLine()) != "Exhibition")            
            {            
                var lineTokens = line.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
                string command = lineTokens[0];
                string plantName = lineTokens[1];

                if (!plants.Any(x => x.Name == plantName))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (command == "Rate")
                {
                    int rating = int.Parse(lineTokens[2]);
                    plants.First(x => x.Name == plantName).Ratings.Add(rating);
                }
                else if (command == "Update")
                {
                    int rarity = int.Parse(lineTokens[2]);
                    plants.First(x => x.Name == plantName).Rarity = rarity;
                }
                else if (command == "Reset")
                {
                    plants.First(x => x.Name == plantName).Ratings = new List<int>();
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant plant in plants)
            {
                double rating = 0.0;
                if (plant.Ratings.Any())
                {
                    rating = plant.Ratings.Average();
                }
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {rating:f2}");
            }
        }
         
        public class Plant
        {
            public Plant(string name, int rarity)
            {
                Name = name;
                Rarity = rarity;
                Ratings = new List<int>();
            }

            public string Name { get; set; }
            public int Rarity { get; set; }
            public List<int> Ratings { get; set; }
        }
    }
}
